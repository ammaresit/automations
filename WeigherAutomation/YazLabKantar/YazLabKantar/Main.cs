using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.SqlClient;

namespace YazLabKantar
{
    public partial class formMain : Form
    {
        
        public formMain(string aut, string usrnm)
        {
            InitializeComponent();

            if (aut.Equals("0")) { btnAddUser.Visible = false; }
            lblUsername.Text = usrnm;
        }

        public formMain()
        {
            InitializeComponent();
        }


        //************************************************ SERIAL PORT İŞLEMLERİ ************************************************

        SerialPort seriPort = new SerialPort("COM1");
        // SERIAL PORT ACTIONS !!!!
        private void getDataSeriPort()
        {
            try
            {
                btnKg.Text = seriPort.ReadExisting() + " KG";
            }
            catch(Exception em)
            {
                MessageBox.Show(em.Message.ToString());
            }
        }


        //************************************************ VERİTABANI BAĞLANTI İŞLEMLERİ ************************************************
        
        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLAMMAR;Initial Catalog=dbKantar;Integrated Security=True");

        private void openConnection()
        {
            connection.Open();
        }

        private void closeConnection()
        {
            connection.Close();
        }


        //************************************************ PANELLER ************************************************


        // GİRİŞ KAYDI PANELİNİ AÇAN BÖLÜM !!!
        private void BtnEntry_Click(object sender, EventArgs e)
        {
            if(!pnlOut.Visible)
            {
                dataGridShow();
                getTruckAmountInside();
                btnKg.Text = " KG";
            }

            if(!pnlEntry.Visible)
            {
                pnlEntry.Visible = true;
                pnlOut.Visible = false;
                lblTrucksInside.Visible = false;
                getDataSeriPort();
            }
            else
            {
                pnlEntry.Visible = false;
                pnlOut.Visible = false;
                lblTrucksInside.Visible = true;
                getTruckAmountInside();
                btnKg.Text = " KG";
            }
        }

        // ÇIKIŞ KAYDI PANELİNİ AÇAN BÖLÜM !!!
        private void BtnCheckout_Click(object sender, EventArgs e)
        {

            if (!pnlOut.Visible)
            {
                pnlOut.Visible = true;
                pnlEntry.Visible = false;
                lblTrucksInside.Visible = false;
                dataGridInShow();
                btnKg.Text = "KG";
            }
            else
            {
                pnlOut.Visible = false;
                pnlEntry.Visible = false;
                lblTrucksInside.Visible = true;
                dataGridShow();
                getTruckAmountInside();
            }
            getDataSeriPort();
        }


        //************************************************ DATA GRID ************************************************


        // DATAGRID'e VERİLERİN ÇEKİLDİĞİ BÖLÜM !!!
        private void dataGridShow()
        {

            string showRecords = "SELECT r.recStatus, r.recEntryKg, r.recOutKg, r.recPayload, r.recDate, r.recTime, t.truckPlateNo, t.truckDriver, u.userFullname FROM tblRecords r INNER JOIN tblTrucks t ON t.ID_Truck = r.ID_Truck INNER JOIN tblUsers u ON u.ID_User = r.ID_User";

            SqlDataAdapter da = new SqlDataAdapter(showRecords, connection);
            DataTable dt = new DataTable();

            try
            {
                openConnection();

                da.Fill(dt);
                dataGridRecords.DataSource = dt;
            }
            catch(Exception em)
            {
                MessageBox.Show(em.Message.ToString());
            }
            finally
            {
                closeConnection();
            }
        }

        private void dataGridInShow()
        {
            string showRecords = "SELECT t.truckLocation, r.recEntryKg, r.recDate, r.recTime, t.truckPlateNo, t.truckDriver FROM tblRecords r INNER JOIN tblTrucks t ON t.ID_Truck = r.ID_Truck WHERE t.truckLocation = '"+1+"'";

            SqlDataAdapter da = new SqlDataAdapter(showRecords, connection);
            DataTable dt = new DataTable();

            try
            {
                openConnection();
                da.Fill(dt);
                dataGridRecords.DataSource = dt;
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message.ToString());
            }
            finally
            {
                closeConnection();
            }
        }

        // DATAGRID'e TIKLANDIĞINDA VERİLERİN ÇIKIŞ YAPMA TEXTBOXLARINA YAZDIRILDIĞI BÖLÜM !!!
        private void DataGridRecords_SelectionChanged(object sender, EventArgs e)
        {
            if(pnlOut.Visible)
            {
                if (dataGridRecords.SelectedRows.Count > 0)
                {
                    txtOutEnterWeight.Text = dataGridRecords.SelectedCells[1].Value.ToString(); // entry kg
                    txtOutCarPlate.Text = dataGridRecords.SelectedCells[4].Value.ToString(); // carplate
                    txtOutDriver.Text = dataGridRecords.SelectedCells[5].Value.ToString(); // driver
                }
            }
        }

        // İÇERİDEKİ KAMYON SAYISINI ALAN BÖLÜM !!!
        private void getTruckAmountInside()
        {

            string getTrucks = "SELECT COUNT(*) FROM tblTrucks WHERE truckLocation = '"+1+"'";
            SqlCommand sql = new SqlCommand(getTrucks, connection);

            try
            {
                openConnection();
                int amount = (int)sql.ExecuteScalar();
                lblTrucksInside.Text = "İçerdeki Araç Sayısı: "+amount.ToString();
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message.ToString());
            }
            finally
            {
                closeConnection();
            }
        }


        //************************************************ KAYITLAR ************************************************

        
        // GİRİŞ KAYDI YAPILMA BÖLÜMÜ !!!!!!
        private void BtnEntrySubmit_Click(object sender, EventArgs e)
        {

            if ((txtEntryDriver.Text.Trim() == "") || (txtEntryPlateNo.Text.Trim() == "") || (txtEntryWeight.Text.Trim() == ""))
            {
                lblEntryError.Visible = true;
            }
            else
            {
                // TXTLERDEKİ VERİLERİ ALIP VT'YE KAYDET
                string time = DateTime.Now.ToString("HH:mm");
                string date = DateTime.Now.ToString("dd/MM/yyyy");


                // BİLGİLERİ TEXTBOXLARDAN ALIR, DİĞER TABLOLARDAN DA İLGİLİ GİRDİLERİN IDLERİNİ ALIP RECORDS TABLOSUNA KAYDEDER !!!
                string insertEntries = "INSERT INTO tblRecords (recStatus, recEntryKg, recOutKg, recPayload, recDate, recTime, ID_Truck, ID_User) SELECT @recStatus, @recEntryKg, @recOutKg, @recPayload, @recDate, @recTime, t.ID_Truck, u.ID_User FROM tblTrucks t, tblUsers u WHERE t.truckPlateNo = @PlateNo AND t.truckDriver = @Driver AND u.userFullname = @username";

                // GİRİLEN KAMYON DAHA ÖNCEDEN TABLODA MEVCUT DEĞİL İSE !!!
                // TRUCK DRIVER'I ve TRUCK PLATE NO'YU TRUCKS TABLOSUNA EKLER !!!
                string insertEntries2 = "INSERT INTO tblTrucks (truckPlateNo, truckDriver, truckLocation) VALUES ('" + txtEntryPlateNo.Text + "', '" + txtEntryDriver.Text + "', 1)";

                // GİRİLEN KAMYON DAHA ÖNCEDEN TABLODA MEVCUT İSE ***********************************************************************************
                // TRUCK DRIVER'I ve TRUCK PLATE NO'YU TRUCKS TABLOSUNDA BULUP LOCATION'I UPDATE EDER !!!
                string insertEntriess2 = "UPDATE tblTrucks SET truckLocation='" + 1 + "' WHERE truckPlateNo = '" + txtEntryPlateNo.Text + "' AND truckDriver = '" + txtEntryDriver.Text + "'";

                SqlCommand cmnd = new SqlCommand(insertEntries, connection);
                SqlCommand cmnd2 = new SqlCommand(insertEntries2, connection);

                cmnd.Parameters.AddWithValue("@recStatus", 1);
                cmnd.Parameters.AddWithValue("@recEntryKg", txtEntryWeight.Text);
                cmnd.Parameters.AddWithValue("@recOutKg", 0);
                cmnd.Parameters.AddWithValue("@recPayload", 0);
                cmnd.Parameters.AddWithValue("@recDate", date);
                cmnd.Parameters.AddWithValue("@recTime", time);
                cmnd.Parameters.AddWithValue("@username", lblUsername.Text);
                cmnd.Parameters.AddWithValue("@PlateNo", txtEntryPlateNo.Text);
                cmnd.Parameters.AddWithValue("@Driver", txtEntryDriver.Text);


                SqlCommand cmndd2 = new SqlCommand(insertEntriess2, connection);

                // TRUCK DAHA ÖNCE KAYITLI MI DİYE KONTROL EDER !!! SONUCUNA GÖRE YA TABLOYA TRUCK EKLER, YA DA MEVCUT TRUCK LOCATION'I UPDATE EDER !!!
                string sentence = "SELECT truckPlateNo, truckDriver FROM tblTrucks WHERE truckPlateNo = '" + txtEntryPlateNo.Text + "' " +
                    " AND truckDriver = '" + txtEntryDriver.Text + "'";

                try
                {
                    SqlCommand command = new SqlCommand(sentence, connection);
                    openConnection();
                    SqlDataReader dr = command.ExecuteReader();

                    if (!dr.Read())
                    {
                        dr.Close();
                        cmnd2.ExecuteNonQuery();
                    }
                    else
                    {
                        dr.Close();
                        cmndd2.ExecuteNonQuery();
                    }

                    cmnd.ExecuteNonQuery();


                    txtEntryDriver.Text = "";
                    txtEntryPlateNo.Text = "";
                    txtEntryWeight.Text = "";

                    lblEntryError.Visible = false;
                    MessageBox.Show("Kayıt Başarılı !..");
                }
                catch(Exception em)
                {
                    MessageBox.Show(em.Message.ToString());
                }
                finally
                {
                    closeConnection();
                }

            }

            getTruckAmountInside();
        }

        // ÇIKIŞ KAYDI YAPILMA BÖLÜMÜ !!!!!!
        private void BtnOutSubmit_Click(object sender, EventArgs e)
        {
            if ((txtOutCarPlate.Text.Trim() == "") || (txtOutDriver.Text.Trim() == "") || (txtOutEnterWeight.Text.Trim() == "") || (txtOutOutWeight.Text.Trim() == "") || (txtOutPayload.Text.Trim() == ""))
            {
                lblOutError.Visible = true;
            }
            else
            {
                // TXTLERDEKİ VERİLERİ ALIP VT'YE KAYDET
                string time = DateTime.Now.ToString("HH:mm");
                string date = DateTime.Now.ToString("dd/MM/yyyy");

                // GİRİLEN KAMYON DAHA ÖNCEDEN TABLODA MEVCUT DEĞİL İSE !!!
                // BİLGİLERİ TEXTBOXLARDAN ALIR, DİĞER TABLOLARDAN DA İLGİLİ GİRDİLERİN IDLERİNİ ALIP RECORDS TABLOSUNA KAYDEDER !!!
                string insertEntries = "INSERT INTO tblRecords(recStatus, recEntryKg, recOutKg, recPayload, recDate, recTime, ID_Truck, ID_User) " +
                    " SELECT @recStatus, @recEntryKg, @recOutKg, @recPayload, @recDate, @recTime, t.ID_Truck, u.ID_User FROM tblTrucks t, tblUsers u WHERE t.truckPlateNo = @PlateNo AND t.truckDriver = @Driver AND u.userFullname = @username";

                // TRUCK DRIVER'I ve TRUCK PLATE NO'YU TRUCKS TABLOSUNA EKLER !!!
                string insertEntries2 = "INSERT INTO tblTrucks (truckPlateNo, truckDriver, truckLocation) VALUES ('" + txtOutCarPlate.Text + "', '" + txtOutDriver.Text + "', 0)";

                // GİRİLEN KAMYON DAHA ÖNCEDEN TABLODA MEVCUT İSE ***********************************************************************************
                // TRUCK DRIVER'I ve TRUCK PLATE NO'YU TRUCKS TABLOSUNDA BULUP LOCATION'I UPDATE EDER !!!
                string insertEntriess2 = "UPDATE tblTrucks SET truckLocation='"+0+"' WHERE truckPlateNo = '"+txtOutCarPlate.Text+"' AND truckDriver = '"+txtOutDriver.Text+"'";

                SqlCommand cmnd1 = new SqlCommand(insertEntries, connection);
                SqlCommand cmnd2 = new SqlCommand(insertEntries2, connection);

                cmnd1.Parameters.AddWithValue("@recStatus", 0);
                cmnd1.Parameters.AddWithValue("@recEntryKg", txtOutEnterWeight.Text);
                cmnd1.Parameters.AddWithValue("@recOutKg", txtOutOutWeight.Text);
                cmnd1.Parameters.AddWithValue("@recPayload", txtOutPayload.Text);
                cmnd1.Parameters.AddWithValue("@recDate", date);
                cmnd1.Parameters.AddWithValue("@recTime", time);
                cmnd1.Parameters.AddWithValue("@username", lblUsername.Text);
                cmnd1.Parameters.AddWithValue("@PlateNo", txtOutCarPlate.Text);
                cmnd1.Parameters.AddWithValue("@Driver", txtOutDriver.Text);


                SqlCommand cmndd2 = new SqlCommand(insertEntriess2, connection);

                // TRUCK DAHA ÖNCE KAYITLI MI DİYE KONTROL EDER !!! SONUCUNA GÖRE YA TABLOYA TRUCK EKLER, YA DA MEVCUT TRUCK LOCATION'I UPDATE EDER !!!
                string sentence = "SELECT truckPlateNo, truckDriver FROM tblTrucks WHERE truckPlateNo = '" + txtOutCarPlate.Text + "' " +
                    " AND truckDriver = '" + txtOutDriver.Text + "'";

                try
                {
                    SqlCommand command = new SqlCommand(sentence, connection);
                    openConnection();
                    SqlDataReader dr = command.ExecuteReader();

                    if (!dr.Read())
                    {
                        dr.Close();
                        cmnd2.ExecuteNonQuery();
                    }
                    else
                    {
                        dr.Close();
                        cmndd2.ExecuteNonQuery();
                    }

                    cmnd1.ExecuteNonQuery();

                    txtOutCarPlate.Text = "";
                    txtOutDriver.Text = "";
                    txtOutEnterWeight.Text = "";
                    txtOutOutWeight.Text = "";
                    txtOutPayload.Text = "";

                    lblOutError.Visible = false;
                    MessageBox.Show("Kayıt Başarılı !..");
                }
                catch (Exception em)
                {
                    MessageBox.Show(em.Message.ToString());
                }
                finally
                {
                    closeConnection();
                }

                getTruckAmountInside();
                dataGridInShow();
            }
        }

        // RAPORLAMA İŞLEMLERİ BÖLÜMÜ !!!!!!
        private void BtnReports_Click(object sender, EventArgs e)
        {
            formReport frm = new formReport();
            frm.Show();
        }


        //************************************************ DİĞER ************************************************


        // KULLANICI EKLEME FORMUNA GİDEN BÖLÜM !!!
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            formLogin frm = new formLogin(true, lblUsername.Text);
            frm.Show();
            this.Close();
        }

        // LOGOUT YAPMA KISMI !!!
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            formLogin frm = new formLogin();
            frm.Show();
            this.Close();
        }

        // FORMU KAPATMA BÖLÜMÜ !!!
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadActions()
        {
            seriPort.DataBits = 8;
            seriPort.Handshake = Handshake.None;
            seriPort.Parity = Parity.None;
            seriPort.StopBits = StopBits.One;

            if (!seriPort.IsOpen) { seriPort.Open(); }
            dataGridShow();
            getTruckAmountInside();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadActions();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (seriPort.IsOpen) { seriPort.Close(); }
        }
    }
}
