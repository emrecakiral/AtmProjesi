namespace AtmDonemProjesi
{
    partial class ParaCekme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaCekme));
            this.lblBakiyeUyari = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBakiyeUyari
            // 
            this.lblBakiyeUyari.AutoSize = true;
            this.lblBakiyeUyari.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiyeUyari.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBakiyeUyari.ForeColor = System.Drawing.Color.Red;
            this.lblBakiyeUyari.Location = new System.Drawing.Point(324, 274);
            this.lblBakiyeUyari.Name = "lblBakiyeUyari";
            this.lblBakiyeUyari.Size = new System.Drawing.Size(323, 35);
            this.lblBakiyeUyari.TabIndex = 23;
            this.lblBakiyeUyari.Text = "Lütfen sadece rakam giriniz.";
            this.lblBakiyeUyari.Visible = false;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBakiye.Location = new System.Drawing.Point(203, 139);
            this.txtBakiye.MaxLength = 8;
            this.txtBakiye.Multiline = true;
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(565, 132);
            this.txtBakiye.TabIndex = 22;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBakiye.TextChanged += new System.EventHandler(this.txtBakiye_TextChanged);
            this.txtBakiye.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBakiye_KeyDown);
            this.txtBakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBakiye_KeyPress);
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.Color.YellowGreen;
            this.btnParaCek.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParaCek.Location = new System.Drawing.Point(355, 445);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(260, 111);
            this.btnParaCek.TabIndex = 24;
            this.btnParaCek.Text = "Onayla";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeri.Location = new System.Drawing.Point(12, 661);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(80, 80);
            this.btnGeri.TabIndex = 29;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(906, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 64);
            this.btnClose.TabIndex = 30;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 46);
            this.label1.TabIndex = 31;
            this.label1.Text = "Çekmek istediğiniz tutarı giriniz";
            // 
            // ParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.lblBakiyeUyari);
            this.Controls.Add(this.txtBakiye);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParaCekme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Çekme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParaCekme_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBakiyeUyari;
        private TextBox txtBakiye;
        private Button btnParaCek;
        private Button btnGeri;
        private Button btnClose;
        private Label label1;
    }
}