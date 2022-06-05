namespace AtmDonemProjesi
{
    partial class Havale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Havale));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTutarUyari = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblTelefonUyari = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtKayitPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTutarUyari);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.lblTelefonUyari);
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.txtKayitPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 729);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgileri eksiksiz doldurun";
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
            this.btnGeri.TabIndex = 29;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(182, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(669, 58);
            this.label2.TabIndex = 22;
            this.label2.Text = "Para göndermek istediğiniz hesabın telefon numarasını \r\nve göndermek istediğiniz " +
    "miktari girin.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTutarUyari
            // 
            this.lblTutarUyari.AutoSize = true;
            this.lblTutarUyari.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTutarUyari.ForeColor = System.Drawing.Color.Red;
            this.lblTutarUyari.Location = new System.Drawing.Point(316, 398);
            this.lblTutarUyari.Name = "lblTutarUyari";
            this.lblTutarUyari.Size = new System.Drawing.Size(247, 25);
            this.lblTutarUyari.TabIndex = 21;
            this.lblTutarUyari.Text = "Lütfen sadece rakam giriniz.";
            this.lblTutarUyari.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tutar*";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(316, 354);
            this.txtTutar.MaxLength = 8;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(295, 41);
            this.txtTutar.TabIndex = 19;
            this.txtTutar.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtTutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTutar_KeyDown);
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // lblTelefonUyari
            // 
            this.lblTelefonUyari.AutoSize = true;
            this.lblTelefonUyari.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefonUyari.ForeColor = System.Drawing.Color.Red;
            this.lblTelefonUyari.Location = new System.Drawing.Point(316, 256);
            this.lblTelefonUyari.Name = "lblTelefonUyari";
            this.lblTelefonUyari.Size = new System.Drawing.Size(247, 25);
            this.lblTelefonUyari.TabIndex = 18;
            this.lblTelefonUyari.Text = "Lütfen sadece rakam giriniz.";
            this.lblTelefonUyari.Visible = false;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGonder.Enabled = false;
            this.btnGonder.Location = new System.Drawing.Point(340, 535);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(235, 88);
            this.btnGonder.TabIndex = 12;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtKayitPhone
            // 
            this.txtKayitPhone.Location = new System.Drawing.Point(316, 212);
            this.txtKayitPhone.MaxLength = 11;
            this.txtKayitPhone.Name = "txtKayitPhone";
            this.txtKayitPhone.PlaceholderText = "05*********";
            this.txtKayitPhone.Size = new System.Drawing.Size(295, 41);
            this.txtKayitPhone.TabIndex = 5;
            this.txtKayitPhone.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtKayitPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKayitPhone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Telefon*";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(894, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 64);
            this.btnClose.TabIndex = 23;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Havale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Havale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Havale_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label lblTutarUyari;
        private Label label5;
        private TextBox txtTutar;
        private Label lblTelefonUyari;
        private Button btnGonder;
        private TextBox txtKayitPhone;
        private Label label1;
        private Button btnGeri;
        private Button btnClose;
    }
}