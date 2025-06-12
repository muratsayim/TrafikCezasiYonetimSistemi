using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Cezası_Yazılımı_TR
{
        public partial class Form1 : Form
        {
            private CezaYonetimi yonetim = new CezaYonetimi();

            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                cmbCezaTipi.Items.AddRange(new[] { "Hız", "Park", "Kırmızı Işık" });
                cmbCezaTipi.SelectedIndex = 0;
                dtpTarih.Value = DateTime.Now;

                PlaceholderAyarla(txtSurucuAdi, "Sürücü Adı");
                PlaceholderAyarla(txtYer, "Ceza Yeri");
                PlaceholderAyarla(txtAciklama, "Açıklama");
                PlaceholderAyarla(txtRaporAd, "Rapor için Sürücü Adı");
            }

            private void PlaceholderAyarla(TextBox textBox, string placeholder)
            {
                textBox.Tag = placeholder;
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;

                textBox.Enter += (s, e) =>
                {
                    if (textBox.Text == placeholder)
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                    }
                };

                textBox.Leave += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = placeholder;
                        textBox.ForeColor = Color.Gray;
                    }
                };
            }

            private void btnCezaEkle_Click(object sender, EventArgs e)
            {
                if (txtSurucuAdi.Text == (string)txtSurucuAdi.Tag || string.IsNullOrWhiteSpace(txtSurucuAdi.Text))
                {
                    MessageBox.Show("Sürücü adı boş olamaz.");
                    return;
                }

                Ceza ceza = null;
                switch (cmbCezaTipi.SelectedItem.ToString())
                {
                    case "Hız":
                        ceza = new HizCezasi();
                        break;
                    case "Park":
                        ceza = new ParkCezasi();
                        break;
                    case "Kırmızı Işık":
                        ceza = new KirmiziIsikCezasi();
                        break;
                }

                if (ceza == null) return;

                ceza.SurucuAdi = txtSurucuAdi.Text.Trim();
                ceza.Tarih = dtpTarih.Value;
                ceza.Yer = txtYer.Text == (string)txtYer.Tag ? "" : txtYer.Text.Trim();
                ceza.Aciklama = txtAciklama.Text == (string)txtAciklama.Tag ? "" : txtAciklama.Text.Trim();

                yonetim.CezaEkle(ceza);
                Temizle();
                GuncelleListeler();
            }

            private void btnOde_Click(object sender, EventArgs e)
            {
                if (lstOdenmemis.SelectedIndex >= 0)
                {
                    var ceza = yonetim.OdenmemisCezalar()[lstOdenmemis.SelectedIndex];
                    ceza.Ode();
                    GuncelleListeler();
                }
            }

            private void btnRaporla_Click(object sender, EventArgs e)
            {
                string surucuAdi = txtRaporAd.Text.Trim();
                if (surucuAdi == (string)txtRaporAd.Tag || string.IsNullOrWhiteSpace(surucuAdi))
                {
                    MessageBox.Show("Sürücü adı girin.");
                    return;
                }

                decimal borc = yonetim.ToplamBorc(surucuAdi);
                lblToplamBorc.Text = $"Toplam Borç: {borc} ₺";
            }

            private void GuncelleListeler()
            {
                lstOdenmemis.Items.Clear();
                lstOdenmemis.Items.AddRange(yonetim.OdenmemisCezalar().Select(c => c.ToString()).ToArray());

                lstOdenmis.Items.Clear();
                lstOdenmis.Items.AddRange(yonetim.OdenenCezalar().Select(c => c.ToString()).ToArray());
            }

            private void Temizle()
            {
                txtSurucuAdi.Text = (string)txtSurucuAdi.Tag;
                txtSurucuAdi.ForeColor = Color.Gray;

                txtYer.Text = (string)txtYer.Tag;
                txtYer.ForeColor = Color.Gray;

                txtAciklama.Text = (string)txtAciklama.Tag;
                txtAciklama.ForeColor = Color.Gray;

                cmbCezaTipi.SelectedIndex = 0;
                dtpTarih.Value = DateTime.Now;
            }
        }
    }