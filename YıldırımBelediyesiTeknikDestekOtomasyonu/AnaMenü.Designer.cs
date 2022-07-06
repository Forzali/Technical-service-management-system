namespace YıldırımBelediyesiTeknikDestekOtomasyonu
{
    partial class AnaMenü
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenü));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnListeleVeDüzenle = new System.Windows.Forms.Button();
            this.btnTlpKayit = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildFormAnaMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildFormAnaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Turquoise;
            this.panelMenu.Controls.Add(this.btnListele);
            this.panelMenu.Controls.Add(this.btnListeleVeDüzenle);
            this.panelMenu.Controls.Add(this.btnTlpKayit);
            this.panelMenu.Controls.Add(this.btnAnaMenu);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListele.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListele.FlatAppearance.BorderSize = 0;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.ForeColor = System.Drawing.Color.Black;
            this.btnListele.Location = new System.Drawing.Point(0, 323);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(250, 45);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "Talep Kayıtları Listesi";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnListeleVeDüzenle
            // 
            this.btnListeleVeDüzenle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListeleVeDüzenle.FlatAppearance.BorderSize = 0;
            this.btnListeleVeDüzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeleVeDüzenle.ForeColor = System.Drawing.Color.Black;
            this.btnListeleVeDüzenle.Location = new System.Drawing.Point(0, 278);
            this.btnListeleVeDüzenle.Name = "btnListeleVeDüzenle";
            this.btnListeleVeDüzenle.Size = new System.Drawing.Size(250, 45);
            this.btnListeleVeDüzenle.TabIndex = 9;
            this.btnListeleVeDüzenle.Text = "Destek Talepleri Listele Ve Düzenle";
            this.btnListeleVeDüzenle.UseVisualStyleBackColor = true;
            this.btnListeleVeDüzenle.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnTlpKayit
            // 
            this.btnTlpKayit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTlpKayit.FlatAppearance.BorderSize = 0;
            this.btnTlpKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTlpKayit.ForeColor = System.Drawing.Color.Black;
            this.btnTlpKayit.Location = new System.Drawing.Point(0, 233);
            this.btnTlpKayit.Name = "btnTlpKayit";
            this.btnTlpKayit.Size = new System.Drawing.Size(250, 45);
            this.btnTlpKayit.TabIndex = 7;
            this.btnTlpKayit.Text = "Destek Kaydı Oluştur";
            this.btnTlpKayit.UseVisualStyleBackColor = true;
            this.btnTlpKayit.Click += new System.EventHandler(this.btnTlpKayit_Click_1);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnaMenu.FlatAppearance.BorderSize = 0;
            this.btnAnaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaMenu.ForeColor = System.Drawing.Color.Black;
            this.btnAnaMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaMenu.Location = new System.Drawing.Point(0, 188);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAnaMenu.Size = new System.Drawing.Size(250, 45);
            this.btnAnaMenu.TabIndex = 6;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 43);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "BİLGİ İŞLEM MÜDÜRLÜĞÜ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 145);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::YıldırımBelediyesiTeknikDestekOtomasyonu.Properties.Resources.Bilgi_İşlem_Müdürlüğü;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildFormAnaMenu
            // 
            this.panelChildFormAnaMenu.Controls.Add(this.pictureBox1);
            this.panelChildFormAnaMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormAnaMenu.Location = new System.Drawing.Point(250, 0);
            this.panelChildFormAnaMenu.Name = "panelChildFormAnaMenu";
            this.panelChildFormAnaMenu.Size = new System.Drawing.Size(684, 561);
            this.panelChildFormAnaMenu.TabIndex = 1;
            this.panelChildFormAnaMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildFormAnaMenu_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::YıldırımBelediyesiTeknikDestekOtomasyonu.Properties.Resources.güncellogopng;
            this.pictureBox1.Location = new System.Drawing.Point(121, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildFormAnaMenu);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "AnaMenü";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.AnaMenü_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildFormAnaMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildFormAnaMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListeleVeDüzenle;
        private System.Windows.Forms.Button btnTlpKayit;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnListele;
    }
}

