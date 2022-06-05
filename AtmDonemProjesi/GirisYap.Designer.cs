namespace AtmDonemProjesi
{
    partial class GirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            this.txtGirisYapPhone = new System.Windows.Forms.TextBox();
            this.txtGirisYapPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblSifreUyariGiris = new System.Windows.Forms.Label();
            this.lblTelefonUyariGiris = new System.Windows.Forms.Label();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGirisYapPhone
            // 
            this.txtGirisYapPhone.Location = new System.Drawing.Point(64, 159);
            this.txtGirisYapPhone.MaxLength = 11;
            this.txtGirisYapPhone.Name = "txtGirisYapPhone";
            this.txtGirisYapPhone.PlaceholderText = "05*********";
            this.txtGirisYapPhone.Size = new System.Drawing.Size(292, 36);
            this.txtGirisYapPhone.TabIndex = 1;
            this.txtGirisYapPhone.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtGirisYapPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGirisYapPhone_KeyPress);
            // 
            // txtGirisYapPass
            // 
            this.txtGirisYapPass.Location = new System.Drawing.Point(64, 291);
            this.txtGirisYapPass.MaxLength = 6;
            this.txtGirisYapPass.Name = "txtGirisYapPass";
            this.txtGirisYapPass.PasswordChar = '*';
            this.txtGirisYapPass.Size = new System.Drawing.Size(292, 36);
            this.txtGirisYapPass.TabIndex = 2;
            this.txtGirisYapPass.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtGirisYapPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGirisYapPass_KeyDown);
            this.txtGirisYapPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGirisYapPass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnGirisYap);
            this.groupBox1.Controls.Add(this.lblSifreUyariGiris);
            this.groupBox1.Controls.Add(this.lblTelefonUyariGiris);
            this.groupBox1.Controls.Add(this.txtGirisYapPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGirisYapPass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 729);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ERC BANK";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(893, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 64);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGirisYap.Enabled = false;
            this.btnGirisYap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGirisYap.Location = new System.Drawing.Point(89, 451);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(227, 75);
            this.btnGirisYap.TabIndex = 21;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblSifreUyariGiris
            // 
            this.lblSifreUyariGiris.AutoSize = true;
            this.lblSifreUyariGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSifreUyariGiris.ForeColor = System.Drawing.Color.Red;
            this.lblSifreUyariGiris.Location = new System.Drawing.Point(64, 330);
            this.lblSifreUyariGiris.Name = "lblSifreUyariGiris";
            this.lblSifreUyariGiris.Size = new System.Drawing.Size(252, 28);
            this.lblSifreUyariGiris.TabIndex = 20;
            this.lblSifreUyariGiris.Text = "Lütfen sadece rakam giriniz.";
            this.lblSifreUyariGiris.Visible = false;
            // 
            // lblTelefonUyariGiris
            // 
            this.lblTelefonUyariGiris.AutoSize = true;
            this.lblTelefonUyariGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefonUyariGiris.ForeColor = System.Drawing.Color.Red;
            this.lblTelefonUyariGiris.Location = new System.Drawing.Point(64, 198);
            this.lblTelefonUyariGiris.Name = "lblTelefonUyariGiris";
            this.lblTelefonUyariGiris.Size = new System.Drawing.Size(252, 28);
            this.lblTelefonUyariGiris.TabIndex = 19;
            this.lblTelefonUyariGiris.Text = "Lütfen sadece rakam giriniz.";
            this.lblTelefonUyariGiris.Visible = false;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniKayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYeniKayit.BackgroundImage")));
            this.btnYeniKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYeniKayit.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnYeniKayit.FlatAppearance.BorderSize = 0;
            this.btnYeniKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniKayit.Location = new System.Drawing.Point(870, 656);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(105, 85);
            this.btnYeniKayit.TabIndex = 6;
            this.btnYeniKayit.TabStop = false;
            this.btnYeniKayit.UseVisualStyleBackColor = false;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "GirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM - Giris Yap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GirisYap_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtGirisYapPhone;
        private TextBox txtGirisYapPass;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblSifreUyariGiris;
        private Label lblTelefonUyariGiris;
        private Button btnYeniKayit;
        private Button btnGirisYap;
        private Button btnClose;
    }
}