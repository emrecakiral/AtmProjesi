namespace AtmDonemProjesi
{
    partial class KayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
            this.txtKayitPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblBakiyeUyari = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.lblTelefonUyari = new System.Windows.Forms.Label();
            this.lblSifreUyari = new System.Windows.Forms.Label();
            this.lblSoyisimUyari = new System.Windows.Forms.Label();
            this.lblIsimUyari = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKayitPhone
            // 
            this.txtKayitPhone.Location = new System.Drawing.Point(502, 142);
            this.txtKayitPhone.MaxLength = 11;
            this.txtKayitPhone.Name = "txtKayitPhone";
            this.txtKayitPhone.PlaceholderText = "05*********";
            this.txtKayitPhone.Size = new System.Drawing.Size(228, 36);
            this.txtKayitPhone.TabIndex = 5;
            this.txtKayitPhone.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtKayitPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKayitPhone_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre*";
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(330, 417);
            this.txtKayitSifre.MaxLength = 6;
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.PasswordChar = '*';
            this.txtKayitSifre.Size = new System.Drawing.Size(228, 36);
            this.txtKayitSifre.TabIndex = 6;
            this.txtKayitSifre.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtKayitSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKayitSifre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Telefon*";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.lblBakiyeUyari);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBakiye);
            this.groupBox1.Controls.Add(this.lblTelefonUyari);
            this.groupBox1.Controls.Add(this.lblSifreUyari);
            this.groupBox1.Controls.Add(this.lblSoyisimUyari);
            this.groupBox1.Controls.Add(this.lblIsimUyari);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnKayitOl);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.txtKayitSifre);
            this.groupBox1.Controls.Add(this.txtKayitPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 729);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgileri eksiksiz doldurun";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(894, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 64);
            this.btnClose.TabIndex = 25;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeri.Location = new System.Drawing.Point(0, 649);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(80, 80);
            this.btnGeri.TabIndex = 30;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblBakiyeUyari
            // 
            this.lblBakiyeUyari.AutoSize = true;
            this.lblBakiyeUyari.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBakiyeUyari.ForeColor = System.Drawing.Color.Red;
            this.lblBakiyeUyari.Location = new System.Drawing.Point(502, 322);
            this.lblBakiyeUyari.Name = "lblBakiyeUyari";
            this.lblBakiyeUyari.Size = new System.Drawing.Size(247, 25);
            this.lblBakiyeUyari.TabIndex = 21;
            this.lblBakiyeUyari.Text = "Lütfen sadece rakam giriniz.";
            this.lblBakiyeUyari.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bakiye*";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(502, 283);
            this.txtBakiye.MaxLength = 8;
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(238, 36);
            this.txtBakiye.TabIndex = 19;
            this.txtBakiye.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtBakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBakiye_KeyPress);
            // 
            // lblTelefonUyari
            // 
            this.lblTelefonUyari.AutoSize = true;
            this.lblTelefonUyari.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefonUyari.ForeColor = System.Drawing.Color.Red;
            this.lblTelefonUyari.Location = new System.Drawing.Point(502, 181);
            this.lblTelefonUyari.Name = "lblTelefonUyari";
            this.lblTelefonUyari.Size = new System.Drawing.Size(247, 25);
            this.lblTelefonUyari.TabIndex = 18;
            this.lblTelefonUyari.Text = "Lütfen sadece rakam giriniz.";
            this.lblTelefonUyari.Visible = false;
            // 
            // lblSifreUyari
            // 
            this.lblSifreUyari.AutoSize = true;
            this.lblSifreUyari.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSifreUyari.ForeColor = System.Drawing.Color.Red;
            this.lblSifreUyari.Location = new System.Drawing.Point(330, 456);
            this.lblSifreUyari.Name = "lblSifreUyari";
            this.lblSifreUyari.Size = new System.Drawing.Size(247, 25);
            this.lblSifreUyari.TabIndex = 17;
            this.lblSifreUyari.Text = "Lütfen sadece rakam giriniz.";
            this.lblSifreUyari.Visible = false;
            // 
            // lblSoyisimUyari
            // 
            this.lblSoyisimUyari.AutoSize = true;
            this.lblSoyisimUyari.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoyisimUyari.ForeColor = System.Drawing.Color.Red;
            this.lblSoyisimUyari.Location = new System.Drawing.Point(158, 322);
            this.lblSoyisimUyari.Name = "lblSoyisimUyari";
            this.lblSoyisimUyari.Size = new System.Drawing.Size(229, 25);
            this.lblSoyisimUyari.TabIndex = 16;
            this.lblSoyisimUyari.Text = "Lütfen sadece harf giriniz.";
            this.lblSoyisimUyari.Visible = false;
            // 
            // lblIsimUyari
            // 
            this.lblIsimUyari.AutoSize = true;
            this.lblIsimUyari.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIsimUyari.ForeColor = System.Drawing.Color.Red;
            this.lblIsimUyari.Location = new System.Drawing.Point(158, 181);
            this.lblIsimUyari.Name = "lblIsimUyari";
            this.lblIsimUyari.Size = new System.Drawing.Size(229, 25);
            this.lblIsimUyari.TabIndex = 15;
            this.lblIsimUyari.Text = "Lütfen sadece harf giriniz.";
            this.lblIsimUyari.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Soyisim*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "İsim*";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKayitOl.Enabled = false;
            this.btnKayitOl.Location = new System.Drawing.Point(345, 570);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(200, 75);
            this.btnKayitOl.TabIndex = 12;
            this.btnKayitOl.Text = "Onayla";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoyisim.Location = new System.Drawing.Point(158, 283);
            this.txtSoyisim.MaxLength = 50;
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(229, 36);
            this.txtSoyisim.TabIndex = 11;
            this.txtSoyisim.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtSoyisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyisim_KeyPress);
            // 
            // txtIsim
            // 
            this.txtIsim.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIsim.Location = new System.Drawing.Point(158, 142);
            this.txtIsim.MaxLength = 50;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(229, 36);
            this.txtIsim.TabIndex = 9;
            this.txtIsim.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtIsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsim_KeyPress);
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Yeni Kayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KayitOl_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtKayitPhone;
        private Label label2;
        private TextBox txtKayitSifre;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Button btnKayitOl;
        private TextBox txtSoyisim;
        private TextBox txtIsim;
        private Label lblTelefonUyari;
        private Label lblSifreUyari;
        private Label lblSoyisimUyari;
        private Label lblIsimUyari;
        private Label lblBakiyeUyari;
        private Label label5;
        private TextBox txtBakiye;
        private Button btnGeri;
        private Button btnClose;
    }
}