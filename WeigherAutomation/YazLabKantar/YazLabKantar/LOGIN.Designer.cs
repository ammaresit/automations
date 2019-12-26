namespace YazLabKantar
{
    partial class formLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.btnLoginHomePage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLoginUSER = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblAddError = new System.Windows.Forms.Label();
            this.cmbAddAuthority = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSubmit = new System.Windows.Forms.Button();
            this.txtAddFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(472, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(146, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(345, 223);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 32);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "GİRİŞ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(195, 146);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Ad Soyad";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(517, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Parola";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(163, 169);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginError.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoginError.Location = new System.Drawing.Point(309, 50);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(200, 25);
            this.lblLoginError.TabIndex = 8;
            this.lblLoginError.Text = "Hatalı Giriş Yaptınız !..";
            this.lblLoginError.Visible = false;
            // 
            // btnLoginHomePage
            // 
            this.btnLoginHomePage.Location = new System.Drawing.Point(12, 391);
            this.btnLoginHomePage.Name = "btnLoginHomePage";
            this.btnLoginHomePage.Size = new System.Drawing.Size(103, 47);
            this.btnLoginHomePage.TabIndex = 10;
            this.btnLoginHomePage.Text = "ANA SAYFA";
            this.btnLoginHomePage.UseVisualStyleBackColor = true;
            this.btnLoginHomePage.Visible = false;
            this.btnLoginHomePage.Click += new System.EventHandler(this.BtnLoginHomePage_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::YazLabKantar.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(638, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 100);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblLoginUSER
            // 
            this.lblLoginUSER.AutoSize = true;
            this.lblLoginUSER.Location = new System.Drawing.Point(0, 0);
            this.lblLoginUSER.Name = "lblLoginUSER";
            this.lblLoginUSER.Size = new System.Drawing.Size(71, 17);
            this.lblLoginUSER.TabIndex = 12;
            this.lblLoginUSER.Text = "username";
            this.lblLoginUSER.Visible = false;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.lblAddError);
            this.pnlAdd.Controls.Add(this.cmbAddAuthority);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.txtAddPassword);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.btnAddSubmit);
            this.pnlAdd.Controls.Add(this.txtAddFullname);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Location = new System.Drawing.Point(108, 50);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(528, 269);
            this.pnlAdd.TabIndex = 17;
            this.pnlAdd.Visible = false;
            // 
            // lblAddError
            // 
            this.lblAddError.AutoSize = true;
            this.lblAddError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddError.ForeColor = System.Drawing.Color.Maroon;
            this.lblAddError.Location = new System.Drawing.Point(158, 231);
            this.lblAddError.Name = "lblAddError";
            this.lblAddError.Size = new System.Drawing.Size(241, 25);
            this.lblAddError.TabIndex = 9;
            this.lblAddError.Text = "Lütfen Boş Bırakmayınız !..";
            this.lblAddError.Visible = false;
            // 
            // cmbAddAuthority
            // 
            this.cmbAddAuthority.FormattingEnabled = true;
            this.cmbAddAuthority.Items.AddRange(new object[] {
            "Normal",
            "Yönetici"});
            this.cmbAddAuthority.Location = new System.Drawing.Point(242, 136);
            this.cmbAddAuthority.Name = "cmbAddAuthority";
            this.cmbAddAuthority.Size = new System.Drawing.Size(157, 24);
            this.cmbAddAuthority.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(87, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yetki Seviyesi";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(242, 99);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PasswordChar = '*';
            this.txtAddPassword.Size = new System.Drawing.Size(157, 22);
            this.txtAddPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // btnAddSubmit
            // 
            this.btnAddSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddSubmit.Location = new System.Drawing.Point(225, 174);
            this.btnAddSubmit.Name = "btnAddSubmit";
            this.btnAddSubmit.Size = new System.Drawing.Size(91, 34);
            this.btnAddSubmit.TabIndex = 4;
            this.btnAddSubmit.Text = "EKLE";
            this.btnAddSubmit.UseVisualStyleBackColor = true;
            this.btnAddSubmit.Click += new System.EventHandler(this.BtnAddSubmit_Click_1);
            // 
            // txtAddFullname
            // 
            this.txtAddFullname.Location = new System.Drawing.Point(242, 63);
            this.txtAddFullname.Name = "txtAddFullname";
            this.txtAddFullname.Size = new System.Drawing.Size(157, 22);
            this.txtAddFullname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.lblLoginUSER);
            this.Controls.Add(this.btnLoginHomePage);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLogin";
            this.Text = "Login";
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Button btnLoginHomePage;
        private System.Windows.Forms.Label lblLoginUSER;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblAddError;
        private System.Windows.Forms.ComboBox cmbAddAuthority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSubmit;
        private System.Windows.Forms.TextBox txtAddFullname;
        private System.Windows.Forms.Label label1;
    }
}