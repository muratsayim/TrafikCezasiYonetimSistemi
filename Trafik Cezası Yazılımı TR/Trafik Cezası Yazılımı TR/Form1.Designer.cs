namespace Trafik_Cezası_Yazılımı_TR
{
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null)) components.Dispose();
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSurucuAdi = new System.Windows.Forms.TextBox();
            this.cmbCezaTipi = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtYer = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnCezaEkle = new System.Windows.Forms.Button();
            this.lstOdenmemis = new System.Windows.Forms.ListBox();
            this.lstOdenmis = new System.Windows.Forms.ListBox();
            this.btnOde = new System.Windows.Forms.Button();
            this.txtRaporAd = new System.Windows.Forms.TextBox();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSurucuAdi
            // 
            this.txtSurucuAdi.Location = new System.Drawing.Point(30, 30);
            this.txtSurucuAdi.Name = "txtSurucuAdi";
            this.txtSurucuAdi.Size = new System.Drawing.Size(200, 22);
            this.txtSurucuAdi.TabIndex = 0;
            // 
            // cmbCezaTipi
            // 
            this.cmbCezaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCezaTipi.FormattingEnabled = true;
            this.cmbCezaTipi.Location = new System.Drawing.Point(30, 69);
            this.cmbCezaTipi.Name = "cmbCezaTipi";
            this.cmbCezaTipi.Size = new System.Drawing.Size(200, 24);
            this.cmbCezaTipi.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(30, 108);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 2;
            // 
            // txtYer
            // 
            this.txtYer.Location = new System.Drawing.Point(30, 145);
            this.txtYer.Name = "txtYer";
            this.txtYer.Size = new System.Drawing.Size(200, 22);
            this.txtYer.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(30, 183);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 62);
            this.txtAciklama.TabIndex = 4;
            // 
            // btnCezaEkle
            // 
            this.btnCezaEkle.Location = new System.Drawing.Point(30, 260);
            this.btnCezaEkle.Name = "btnCezaEkle";
            this.btnCezaEkle.Size = new System.Drawing.Size(200, 30);
            this.btnCezaEkle.TabIndex = 5;
            this.btnCezaEkle.Text = "Ceza Ekle";
            this.btnCezaEkle.UseVisualStyleBackColor = true;
            this.btnCezaEkle.Click += new System.EventHandler(this.btnCezaEkle_Click);
            // 
            // lstOdenmemis
            // 
            this.lstOdenmemis.FormattingEnabled = true;
            this.lstOdenmemis.ItemHeight = 16;
            this.lstOdenmemis.Location = new System.Drawing.Point(260, 30);
            this.lstOdenmemis.Name = "lstOdenmemis";
            this.lstOdenmemis.Size = new System.Drawing.Size(500, 100);
            this.lstOdenmemis.TabIndex = 6;
            // 
            // lstOdenmis
            // 
            this.lstOdenmis.FormattingEnabled = true;
            this.lstOdenmis.ItemHeight = 16;
            this.lstOdenmis.Location = new System.Drawing.Point(260, 145);
            this.lstOdenmis.Name = "lstOdenmis";
            this.lstOdenmis.Size = new System.Drawing.Size(500, 100);
            this.lstOdenmis.TabIndex = 7;
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(260, 260);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(500, 30);
            this.btnOde.TabIndex = 8;
            this.btnOde.Text = "Seçilen Cezayı Öde";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // txtRaporAd
            // 
            this.txtRaporAd.Location = new System.Drawing.Point(30, 305);
            this.txtRaporAd.Name = "txtRaporAd";
            this.txtRaporAd.Size = new System.Drawing.Size(200, 22);
            this.txtRaporAd.TabIndex = 9;
            // 
            // btnRaporla
            // 
            this.btnRaporla.Location = new System.Drawing.Point(30, 342);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(200, 30);
            this.btnRaporla.TabIndex = 10;
            this.btnRaporla.Text = "Borç Raporu";
            this.btnRaporla.UseVisualStyleBackColor = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.ForeColor = System.Drawing.Color.Red;
            this.lblToplamBorc.Location = new System.Drawing.Point(30, 384);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(200, 30);
            this.lblToplamBorc.TabIndex = 11;
            this.lblToplamBorc.Text = "Toplam Borç: 0 ₺";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(962, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(777, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 215);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1165, 532);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.btnRaporla);
            this.Controls.Add(this.txtRaporAd);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lstOdenmis);
            this.Controls.Add(this.lstOdenmemis);
            this.Controls.Add(this.btnCezaEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtYer);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbCezaTipi);
            this.Controls.Add(this.txtSurucuAdi);
            this.Name = "Form1";
            this.Text = "TRAFİK CEZASI YAZILIMI TR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.TextBox txtSurucuAdi;
            private System.Windows.Forms.ComboBox cmbCezaTipi;
            private System.Windows.Forms.DateTimePicker dtpTarih;
            private System.Windows.Forms.TextBox txtYer;
            private System.Windows.Forms.TextBox txtAciklama;
            private System.Windows.Forms.Button btnCezaEkle;
            private System.Windows.Forms.ListBox lstOdenmemis;
            private System.Windows.Forms.ListBox lstOdenmis;
            private System.Windows.Forms.Button btnOde;
            private System.Windows.Forms.TextBox txtRaporAd;
            private System.Windows.Forms.Button btnRaporla;
            private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
    }