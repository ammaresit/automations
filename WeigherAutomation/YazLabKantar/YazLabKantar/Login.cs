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
using System.IO.Ports;

namespace YazLabKantar
{
    public partial class formLogin : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source =.\SQLAMMAR;Initial Catalog=dbKantar;Integrated Security=True");
        
        public void openConnection()
        {
            try
            {
                connection.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
                
        }
        public void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        

        public formLogin()
        {
            InitializeComponent();
        }

        // KULLANICI EKLE KISMINDAN GELEN EMİR DOĞRULTUSUNDA AÇILAN FORM !!!
        public formLogin(bool tru, string usrn)
        {
            InitializeComponent();

            pnlAdd.Visible = true;
            cmbAddAuthority.SelectedIndex = 0;
            btnLoginHomePage.Visible = true;
            lblLoginUSER.Text = usrn;
        }




        // LOGIN PAGE SUBMIT BUTTON ACTIONS !!!
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text.Trim() == "") || (txtPassword.Text.Trim() == ""))
            {
                lblLoginError.Text = "Lütfen Boş Bırakmayınız !..";
                lblLoginError.Visible = true;
            }
            
            //GİRİLEN BİLGİLERİN DOĞRULUĞU KONTROL EDİLİR. HATA VAR İSE IF'E GİRER !..
            else {

                try {

                    string loginCntrl = "SELECT userFullname, userPassword, userAuthorization FROM tblUsers WHERE userFullname = '" + txtUsername.Text + "' AND userPassword = '" + txtPassword.Text + "'";
                    SqlCommand cmnd = new SqlCommand(loginCntrl, connection);
                    openConnection();
                    SqlDataReader dataReader = cmnd.ExecuteReader();

                    if(!dataReader.Read())
                    {
                        lblLoginError.Text = "Hatalı Giriş Yaptınız !..";
                        lblLoginError.Visible = true;

                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }
                    else
                    {
                        txtUsername.Text = "";
                        txtPassword.Text = "";

                        lblLoginError.Visible = false;

                        string usrnm = dataReader[0].ToString();
                        string aut = dataReader[2].ToString();

                        formMain frmMain = new formMain(aut, usrnm);
                        frmMain.Show();
                        this.Hide();
                    }

                    dataReader.Close();
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

        // ADDUSER SUBMIT BUTTON ACTIONS !!!
        private void BtnAddSubmit_Click_1(object sender, EventArgs e)
        {
            if ((txtAddFullname.Text.Trim() == "") || (txtAddPassword.Text.Trim() == ""))
            {
                lblAddError.Visible = true;
            }
            else
            {
                char authority;
                if (cmbAddAuthority.SelectedIndex == 0) authority = '0';
                else { authority = '1'; }

                string insertUser = "INSERT INTO tblUsers (userFullname, userPassword, userAuthorization) " +
                    " VALUES ('" + txtAddFullname.Text + "', '" + txtAddPassword.Text + "', '" + authority + "');";
                SqlCommand cmndInsertUser = new SqlCommand(insertUser, connection);

                try
                {
                    openConnection();
                    cmndInsertUser.ExecuteNonQuery();
                }
                catch (Exception em)
                {
                    MessageBox.Show(em.Message.ToString());
                }
                finally
                {
                    closeConnection();
                }

                txtAddFullname.Text = "";
                txtAddPassword.Text = "";
                cmbAddAuthority.SelectedIndex = 0;

                lblAddError.Visible = false;
                MessageBox.Show("Kayıt Başarılı !..");

            }
        }




        // KULLANICI KAYDI YAPILDIKTAN SONRA ANASAYFA'YA DÖNME BUTONU !!!
        private void BtnLoginHomePage_Click(object sender, EventArgs e)
        {
            formMain frmMain = new formMain("1", lblLoginUSER.Text);
            frmMain.Show();
            this.Hide();
        }

        // FORMUN KAPATILMASI BÖLÜMÜ !!!
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
