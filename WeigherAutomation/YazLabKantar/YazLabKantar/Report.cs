using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazLabKantar
{
    public partial class formReport : Form
    {
        public formReport()
        {
            InitializeComponent();
        }
        private void FormReport_Load(object sender, EventArgs e)
        {
            getDatasIntoCmb();
        }


        //************************************************ SERIAL PORT İŞLEMLERİ ************************************************


        SqlConnection connection = new SqlConnection(@"Data Source=PANDA\SQLAMMAR;Initial Catalog=dbKantar;Integrated Security=True");

        private void openConnection()
        {
            connection.Open();
        }

        private void closeConnection()
        {
            connection.Close();
        }


        //************************************************ DATABASE VERİ ÇEKME İŞLEMLERİ ************************************************

        // COMBOBOXLARIN İÇİNİ DOLDURMA BÖLÜMÜ !!!
        private void getDatasIntoCmb()
        {

            string query = "SELECT DISTINCT recDate FROM tblRecords";
            string query2 = "SELECT DISTINCT truckDriver FROM tblTrucks";
            string query3 = "SELECT DISTINCT truckPlateNo FROM tblTrucks";
            string query4 = "SELECT DISTINCT userFullname FROM tblUsers";

            SqlCommand cmnd = new SqlCommand(query, connection);
            SqlCommand cmnd1 = new SqlCommand(query2, connection);
            SqlCommand cmnd2 = new SqlCommand(query3, connection);
            SqlCommand cmnd3 = new SqlCommand(query4, connection);

            SqlDataReader dr;

            try
            {

                openConnection();
                dr = cmnd.ExecuteReader();
                
                while (dr.Read())
                {
                    cmbDate.Items.Add(dr["recDate"].ToString());
                }
                dr.Close();

                dr = cmnd1.ExecuteReader();

                while (dr.Read())
                {
                    cmbDriver.Items.Add(dr["truckDriver"].ToString());
                }
                dr.Close();

                dr = cmnd2.ExecuteReader();

                while (dr.Read())
                {
                    cmbCarPlate.Items.Add(dr["truckPlateNo"].ToString());
                }
                dr.Close();

                dr = cmnd3.ExecuteReader();

                while (dr.Read())
                {
                    cmbUser.Items.Add(dr["userFullname"].ToString());
                }
                dr.Close();

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

        // ARAMA BUTONUNA BASILDIĞINDA FİLTERİ OLARAK DATAGRID'I DOLDURACAK BÖLÜM !!!
        private void BtnSearch_Click(object sender, EventArgs e)
        {

            string query = "SELECT r.recStatus, r.recPayload, r.recDate, t.truckPlateNo, t.truckDriver, u.userFullname FROM tblRecords r" +
                " INNER JOIN tblTrucks t ON t.ID_Truck = r.ID_Truck" +
                " INNER JOIN tblUsers u ON u.ID_User = r.ID_User";
            string queryAdd = " ";

            if (cmbCarPlate.SelectedItem != null && queryAdd.Equals(" ")) queryAdd += "WHERE t.truckPlateNo = '" + cmbCarPlate.SelectedItem.ToString() + "'";
            else if (cmbCarPlate.SelectedItem != null && !queryAdd.Equals(" ")) queryAdd += " AND t.truckPlateNo = '" + cmbCarPlate.SelectedItem.ToString() + "'";

            if (cmbDriver.SelectedItem != null && queryAdd.Equals(" ")) queryAdd += "WHERE t.truckDriver = '" + cmbDriver.SelectedItem.ToString() + "'";
            else if (cmbDriver.SelectedItem != null && !queryAdd.Equals(" ")) queryAdd += " AND t.truckDriver = '" + cmbDriver.SelectedItem.ToString() + "'";

            if (cmbDate.SelectedItem != null && queryAdd.Equals(" ")) queryAdd += "WHERE r.recDate = '" + cmbDate.SelectedItem.ToString() + "'";
            else if (cmbDate.SelectedItem != null && !queryAdd.Equals(" ")) queryAdd += " AND r.recDate = '" + cmbDate.SelectedItem.ToString() + "'";

            if (cmbUser.SelectedItem != null && queryAdd.Equals(" ")) queryAdd += "WHERE u.userFullname = '" + cmbUser.SelectedItem.ToString() + "'";
            else if (cmbUser.SelectedItem != null && !queryAdd.Equals(" ")) queryAdd += " AND u.userFullname = '" + cmbUser.SelectedItem.ToString() + "'";

            if(cmbStatus.SelectedItem != null)
            {
                string status = "";
                if (cmbStatus.SelectedItem.ToString().Equals("Giriş")) status = "1";
                else if (cmbStatus.SelectedItem.ToString().Equals("Çıkış")) status = "0";

                if (queryAdd.Equals(" ")) queryAdd += "WHERE r.recStatus = '" + status + "'";
                else if (!queryAdd.Equals(" ")) queryAdd += " AND r.recStatus = '" + status + "'";
            }

            query += queryAdd;
            
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();

            try
            {
                openConnection();

                da.Fill(dt);
                dataGridReport.DataSource = dt;

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




    }
}
