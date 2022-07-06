namespace YıldırımBelediyesiTeknikDestekOtomasyonu
{
    partial class DestekKaydi
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxKayit = new System.Windows.Forms.GroupBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtTalep = new System.Windows.Forms.TextBox();
            this.comboBoxDurum = new System.Windows.Forms.ComboBox();
            this.comboBoxMüdürlük = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBoxKayit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(684, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "DESTEK KAYDI OLUŞTURMA MENÜSÜ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 50);
            this.panel1.TabIndex = 6;
            // 
            // groupBoxKayit
            // 
            this.groupBoxKayit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxKayit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBoxKayit.Controls.Add(this.panel2);
            this.groupBoxKayit.Location = new System.Drawing.Point(12, 56);
            this.groupBoxKayit.Name = "groupBoxKayit";
            this.groupBoxKayit.Size = new System.Drawing.Size(660, 493);
            this.groupBoxKayit.TabIndex = 7;
            this.groupBoxKayit.TabStop = false;
            this.groupBoxKayit.Text = "Kayıt Oluştur";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Bisque;
            this.btnKayit.Location = new System.Drawing.Point(164, 308);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(82, 30);
            this.btnKayit.TabIndex = 10;
            this.btnKayit.Text = "Kayıt Oluştur ";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtTalep
            // 
            this.txtTalep.Location = new System.Drawing.Point(127, 209);
            this.txtTalep.Multiline = true;
            this.txtTalep.Name = "txtTalep";
            this.txtTalep.Size = new System.Drawing.Size(151, 83);
            this.txtTalep.TabIndex = 9;
            // 
            // comboBoxDurum
            // 
            this.comboBoxDurum.FormattingEnabled = true;
            this.comboBoxDurum.Items.AddRange(new object[] {
            "Normal",
            "Orta",
            "Acil"});
            this.comboBoxDurum.Location = new System.Drawing.Point(127, 157);
            this.comboBoxDurum.Name = "comboBoxDurum";
            this.comboBoxDurum.Size = new System.Drawing.Size(151, 21);
            this.comboBoxDurum.TabIndex = 8;
            this.comboBoxDurum.Text = "Belirtilmedi...";
            // 
            // comboBoxMüdürlük
            // 
            this.comboBoxMüdürlük.FormattingEnabled = true;
            this.comboBoxMüdürlük.Items.AddRange(new object[] {
            "Belediye Tiyatro Müdürlüğü",
            "Çevre Koruma ve Kontrol Müdürlüğü",
            "Destek Hizmetleri Müdürlüğü",
            "Dış İlişkiler Müdürlüğü",
            "Fen İşleri Müdürlüğü",
            "Hukuk İşleri Müdürlüğü",
            "İç Denetim Birim Başkanlığı",
            "İmar ve Şehircilik Müdürlüğü",
            "İnsan Kaynakları ve Eğitim Müdürlüğü",
            "Kentsel Tasarım Müdürlüğü",
            "Koordinasyon İşleri Müdürlüğü",
            "Kültür ve Sosyal İşler Müdürlüğü",
            "Kütüphane Müdürlüğü",
            "Mali Hizmetler Müdürlüğü",
            "Özel Kalem Müdürlüğü",
            "Park ve Bahçeler Müdürlüğü",
            "Plan ve Proje Müdürlüğü",
            "Sağlık İşleri Müdürlüğü",
            "Sosyal Destek İşleri Müdürlüğü",
            "Strateji Geliştirme Müdürlüğü",
            "Teftiş Kurulu Müdürlüğü",
            "Temizlik İşleri Müdürlüğü",
            "Veteriner İşleri Müdürlüğü",
            "Yapı Kontrol Müdürlüğü",
            "Yazı İşleri Müdürlüğü",
            "Zabıta Müdürlüğü"});
            this.comboBoxMüdürlük.Location = new System.Drawing.Point(127, 118);
            this.comboBoxMüdürlük.Name = "comboBoxMüdürlük";
            this.comboBoxMüdürlük.Size = new System.Drawing.Size(151, 21);
            this.comboBoxMüdürlük.TabIndex = 7;
            this.comboBoxMüdürlük.Text = "Seçiniz...";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(127, 71);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(151, 20);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(127, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(151, 20);
            this.txtAd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(43, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Talep :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durum :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müdürlük :";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.txtTalep);
            this.panel2.Controls.Add(this.btnKayit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxDurum);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxMüdürlük);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSoyad);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAd);
            this.panel2.Location = new System.Drawing.Point(153, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 347);
            this.panel2.TabIndex = 11;
            // 
            // DestekKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.groupBoxKayit);
            this.Controls.Add(this.panel1);
            this.Name = "DestekKaydi";
            this.Text = "DestekKaydi";
            this.Load += new System.EventHandler(this.DestekKaydi_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxKayit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxKayit;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtTalep;
        private System.Windows.Forms.ComboBox comboBoxDurum;
        private System.Windows.Forms.ComboBox comboBoxMüdürlük;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}