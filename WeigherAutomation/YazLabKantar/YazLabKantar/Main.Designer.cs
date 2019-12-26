namespace YazLabKantar
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dataGridRecords = new System.Windows.Forms.DataGridView();
            this.lblTrucksInside = new System.Windows.Forms.Label();
            this.btnKg = new System.Windows.Forms.Button();
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.lblEntryError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntryDriver = new System.Windows.Forms.TextBox();
            this.txtEntryWeight = new System.Windows.Forms.TextBox();
            this.txtEntryPlateNo = new System.Windows.Forms.TextBox();
            this.btnEntrySubmit = new System.Windows.Forms.Button();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.lblOutError = new System.Windows.Forms.Label();
            this.btnOutSubmit = new System.Windows.Forms.Button();
            this.txtOutPayload = new System.Windows.Forms.TextBox();
            this.lblPayload = new System.Windows.Forms.Label();
            this.txtOutOutWeight = new System.Windows.Forms.TextBox();
            this.lblOutWeight = new System.Windows.Forms.Label();
            this.txtOutEnterWeight = new System.Windows.Forms.TextBox();
            this.lblEntryWeight = new System.Windows.Forms.Label();
            this.txtOutDriver = new System.Windows.Forms.TextBox();
            this.lblDriver = new System.Windows.Forms.Label();
            this.txtOutCarPlate = new System.Windows.Forms.TextBox();
            this.lblCarPlate = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).BeginInit();
            this.pnlEntry.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1007, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(816, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "KANTAR LTD. ŞTİ.";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(12, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(192, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "KULLANICI: AD SOYAD";
            // 
            // dataGridRecords
            // 
            this.dataGridRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecords.Location = new System.Drawing.Point(12, 43);
            this.dataGridRecords.Name = "dataGridRecords";
            this.dataGridRecords.RowTemplate.Height = 24;
            this.dataGridRecords.Size = new System.Drawing.Size(755, 490);
            this.dataGridRecords.TabIndex = 11;
            this.dataGridRecords.SelectionChanged += new System.EventHandler(this.DataGridRecords_SelectionChanged);
            // 
            // lblTrucksInside
            // 
            this.lblTrucksInside.AutoSize = true;
            this.lblTrucksInside.BackColor = System.Drawing.Color.Transparent;
            this.lblTrucksInside.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrucksInside.Location = new System.Drawing.Point(506, 555);
            this.lblTrucksInside.Name = "lblTrucksInside";
            this.lblTrucksInside.Size = new System.Drawing.Size(231, 25);
            this.lblTrucksInside.TabIndex = 12;
            this.lblTrucksInside.Text = "İçerideki Kamyon Sayısı: ";
            // 
            // btnKg
            // 
            this.btnKg.BackColor = System.Drawing.Color.Black;
            this.btnKg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKg.ForeColor = System.Drawing.Color.White;
            this.btnKg.Location = new System.Drawing.Point(791, 43);
            this.btnKg.Name = "btnKg";
            this.btnKg.Size = new System.Drawing.Size(275, 72);
            this.btnKg.TabIndex = 13;
            this.btnKg.Text = " KG";
            this.btnKg.UseVisualStyleBackColor = false;
            // 
            // pnlEntry
            // 
            this.pnlEntry.Controls.Add(this.lblEntryError);
            this.pnlEntry.Controls.Add(this.label3);
            this.pnlEntry.Controls.Add(this.label);
            this.pnlEntry.Controls.Add(this.label4);
            this.pnlEntry.Controls.Add(this.txtEntryDriver);
            this.pnlEntry.Controls.Add(this.txtEntryWeight);
            this.pnlEntry.Controls.Add(this.txtEntryPlateNo);
            this.pnlEntry.Controls.Add(this.btnEntrySubmit);
            this.pnlEntry.Location = new System.Drawing.Point(12, 43);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(755, 490);
            this.pnlEntry.TabIndex = 45;
            this.pnlEntry.Visible = false;
            // 
            // lblEntryError
            // 
            this.lblEntryError.AutoSize = true;
            this.lblEntryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEntryError.ForeColor = System.Drawing.Color.Maroon;
            this.lblEntryError.Location = new System.Drawing.Point(283, 430);
            this.lblEntryError.Name = "lblEntryError";
            this.lblEntryError.Size = new System.Drawing.Size(241, 25);
            this.lblEntryError.TabIndex = 52;
            this.lblEntryError.Text = "Lütfen Boş Bırakmayınız !..";
            this.lblEntryError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(367, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "ŞOFÖR";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(367, 282);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 24);
            this.label.TabIndex = 50;
            this.label.Text = "AĞIRLIK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(367, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "PLAKA";
            // 
            // txtEntryDriver
            // 
            this.txtEntryDriver.Location = new System.Drawing.Point(298, 198);
            this.txtEntryDriver.Name = "txtEntryDriver";
            this.txtEntryDriver.Size = new System.Drawing.Size(207, 22);
            this.txtEntryDriver.TabIndex = 47;
            // 
            // txtEntryWeight
            // 
            this.txtEntryWeight.Location = new System.Drawing.Point(298, 309);
            this.txtEntryWeight.Name = "txtEntryWeight";
            this.txtEntryWeight.Size = new System.Drawing.Size(207, 22);
            this.txtEntryWeight.TabIndex = 48;
            // 
            // txtEntryPlateNo
            // 
            this.txtEntryPlateNo.Location = new System.Drawing.Point(298, 94);
            this.txtEntryPlateNo.Name = "txtEntryPlateNo";
            this.txtEntryPlateNo.Size = new System.Drawing.Size(207, 22);
            this.txtEntryPlateNo.TabIndex = 46;
            // 
            // btnEntrySubmit
            // 
            this.btnEntrySubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEntrySubmit.Location = new System.Drawing.Point(354, 364);
            this.btnEntrySubmit.Name = "btnEntrySubmit";
            this.btnEntrySubmit.Size = new System.Drawing.Size(109, 36);
            this.btnEntrySubmit.TabIndex = 49;
            this.btnEntrySubmit.Text = "KAYDET";
            this.btnEntrySubmit.UseVisualStyleBackColor = true;
            this.btnEntrySubmit.Click += new System.EventHandler(this.BtnEntrySubmit_Click);
            // 
            // pnlOut
            // 
            this.pnlOut.Controls.Add(this.lblOutError);
            this.pnlOut.Controls.Add(this.btnOutSubmit);
            this.pnlOut.Controls.Add(this.txtOutPayload);
            this.pnlOut.Controls.Add(this.lblPayload);
            this.pnlOut.Controls.Add(this.txtOutOutWeight);
            this.pnlOut.Controls.Add(this.lblOutWeight);
            this.pnlOut.Controls.Add(this.txtOutEnterWeight);
            this.pnlOut.Controls.Add(this.lblEntryWeight);
            this.pnlOut.Controls.Add(this.txtOutDriver);
            this.pnlOut.Controls.Add(this.lblDriver);
            this.pnlOut.Controls.Add(this.txtOutCarPlate);
            this.pnlOut.Controls.Add(this.lblCarPlate);
            this.pnlOut.Location = new System.Drawing.Point(791, 137);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(275, 376);
            this.pnlOut.TabIndex = 46;
            this.pnlOut.Visible = false;
            // 
            // lblOutError
            // 
            this.lblOutError.AutoSize = true;
            this.lblOutError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOutError.ForeColor = System.Drawing.Color.Maroon;
            this.lblOutError.Location = new System.Drawing.Point(25, 347);
            this.lblOutError.Name = "lblOutError";
            this.lblOutError.Size = new System.Drawing.Size(241, 25);
            this.lblOutError.TabIndex = 53;
            this.lblOutError.Text = "Lütfen Boş Bırakmayınız !..";
            this.lblOutError.Visible = false;
            // 
            // btnOutSubmit
            // 
            this.btnOutSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOutSubmit.Location = new System.Drawing.Point(81, 308);
            this.btnOutSubmit.Name = "btnOutSubmit";
            this.btnOutSubmit.Size = new System.Drawing.Size(109, 36);
            this.btnOutSubmit.TabIndex = 48;
            this.btnOutSubmit.Text = "KAYDET";
            this.btnOutSubmit.UseVisualStyleBackColor = true;
            this.btnOutSubmit.Click += new System.EventHandler(this.BtnOutSubmit_Click);
            // 
            // txtOutPayload
            // 
            this.txtOutPayload.Location = new System.Drawing.Point(0, 280);
            this.txtOutPayload.Name = "txtOutPayload";
            this.txtOutPayload.Size = new System.Drawing.Size(275, 22);
            this.txtOutPayload.TabIndex = 47;
            // 
            // lblPayload
            // 
            this.lblPayload.AutoSize = true;
            this.lblPayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPayload.Location = new System.Drawing.Point(77, 257);
            this.lblPayload.Name = "lblPayload";
            this.lblPayload.Size = new System.Drawing.Size(101, 20);
            this.lblPayload.TabIndex = 46;
            this.lblPayload.Text = "Ürün Ağırlığı";
            // 
            // txtOutOutWeight
            // 
            this.txtOutOutWeight.Location = new System.Drawing.Point(0, 217);
            this.txtOutOutWeight.Name = "txtOutOutWeight";
            this.txtOutOutWeight.Size = new System.Drawing.Size(275, 22);
            this.txtOutOutWeight.TabIndex = 45;
            // 
            // lblOutWeight
            // 
            this.lblOutWeight.AutoSize = true;
            this.lblOutWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOutWeight.Location = new System.Drawing.Point(76, 194);
            this.lblOutWeight.Name = "lblOutWeight";
            this.lblOutWeight.Size = new System.Drawing.Size(102, 20);
            this.lblOutWeight.TabIndex = 44;
            this.lblOutWeight.Text = "Çıkış Ağırlığı";
            // 
            // txtOutEnterWeight
            // 
            this.txtOutEnterWeight.Location = new System.Drawing.Point(0, 156);
            this.txtOutEnterWeight.Name = "txtOutEnterWeight";
            this.txtOutEnterWeight.Size = new System.Drawing.Size(275, 22);
            this.txtOutEnterWeight.TabIndex = 43;
            // 
            // lblEntryWeight
            // 
            this.lblEntryWeight.AutoSize = true;
            this.lblEntryWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEntryWeight.Location = new System.Drawing.Point(76, 133);
            this.lblEntryWeight.Name = "lblEntryWeight";
            this.lblEntryWeight.Size = new System.Drawing.Size(101, 20);
            this.lblEntryWeight.TabIndex = 42;
            this.lblEntryWeight.Text = "Giriş Ağırlığı";
            // 
            // txtOutDriver
            // 
            this.txtOutDriver.Location = new System.Drawing.Point(0, 97);
            this.txtOutDriver.Name = "txtOutDriver";
            this.txtOutDriver.Size = new System.Drawing.Size(275, 22);
            this.txtOutDriver.TabIndex = 41;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDriver.Location = new System.Drawing.Point(102, 74);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(49, 20);
            this.lblDriver.TabIndex = 40;
            this.lblDriver.Text = "Şoför";
            // 
            // txtOutCarPlate
            // 
            this.txtOutCarPlate.Location = new System.Drawing.Point(0, 37);
            this.txtOutCarPlate.Name = "txtOutCarPlate";
            this.txtOutCarPlate.Size = new System.Drawing.Size(275, 22);
            this.txtOutCarPlate.TabIndex = 39;
            // 
            // lblCarPlate
            // 
            this.lblCarPlate.AutoSize = true;
            this.lblCarPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarPlate.Location = new System.Drawing.Point(102, 14);
            this.lblCarPlate.Name = "lblCarPlate";
            this.lblCarPlate.Size = new System.Drawing.Size(50, 20);
            this.lblCarPlate.TabIndex = 38;
            this.lblCarPlate.Text = "Plaka";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddUser.Location = new System.Drawing.Point(791, 545);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(72, 35);
            this.btnAddUser.TabIndex = 47;
            this.btnAddUser.Text = "KULLANICI EKLE";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::YazLabKantar.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(890, 519);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 80);
            this.btnLogout.TabIndex = 48;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::YazLabKantar.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(988, 519);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 80);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BackgroundImage = global::YazLabKantar.Properties.Resources.report;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReports.Location = new System.Drawing.Point(366, 539);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(120, 57);
            this.btnReports.TabIndex = 9;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckout.BackgroundImage = global::YazLabKantar.Properties.Resources._out;
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckout.Location = new System.Drawing.Point(206, 539);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 57);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.Transparent;
            this.btnEntry.BackgroundImage = global::YazLabKantar.Properties.Resources.entry;
            this.btnEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEntry.Location = new System.Drawing.Point(43, 539);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(120, 57);
            this.btnEntry.TabIndex = 7;
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.BtnEntry_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.pnlOut);
            this.Controls.Add(this.pnlEntry);
            this.Controls.Add(this.btnKg);
            this.Controls.Add(this.lblTrucksInside);
            this.Controls.Add(this.dataGridRecords);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.Text = "KANTAR OTOMASYON by Ertumar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).EndInit();
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            this.pnlOut.ResumeLayout(false);
            this.pnlOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridRecords;
        private System.Windows.Forms.Label lblTrucksInside;
        private System.Windows.Forms.Button btnKg;
        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntryDriver;
        private System.Windows.Forms.TextBox txtEntryWeight;
        private System.Windows.Forms.TextBox txtEntryPlateNo;
        private System.Windows.Forms.Button btnEntrySubmit;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Button btnOutSubmit;
        private System.Windows.Forms.TextBox txtOutPayload;
        private System.Windows.Forms.Label lblPayload;
        private System.Windows.Forms.TextBox txtOutOutWeight;
        private System.Windows.Forms.Label lblOutWeight;
        private System.Windows.Forms.TextBox txtOutEnterWeight;
        private System.Windows.Forms.Label lblEntryWeight;
        private System.Windows.Forms.TextBox txtOutDriver;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.TextBox txtOutCarPlate;
        private System.Windows.Forms.Label lblCarPlate;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblEntryError;
        private System.Windows.Forms.Label lblOutError;
        private System.Windows.Forms.Button btnLogout;
    }
}

