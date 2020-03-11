using KafeKod.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKod
{
    public partial class UrunlerForm : Form
    {
        KafeContext db;
        BindingList<Urun> blUrunler;
        public UrunlerForm(KafeContext kafeVeri)
        {
            db = kafeVeri;
            InitializeComponent();
            dgvUrunler.AutoGenerateColumns = false;
            dgvUrunler.RowTemplate.Height = 90;
            blUrunler = new BindingList<Urun>(db.Urunler);
            dgvUrunler.DataSource = blUrunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urunAd = txtUrunAd.Text.Trim();
            if (urunAd == "")
            {
                MessageBox.Show("Lütfen ürün adı giriniz !");
                return;

            }

            blUrunler.Add(new Urun
            {
                UrunAd = urunAd,
                BirimFiyat = nudBirimFiyat.Value
            });
            db.Urunler.Sort();
        }

        private void dgvUrunler_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Geçersiz bir değer girdiniz . Lütfen tekrar deneyiniz.");
            
        }

        private void dgvUrunler_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex ==0)   // o an düzenlenen hücre 1. hücre ise   ÜrünAd ı düzenliyorsa
            {
                if (e.FormattedValue.ToString().Trim()== "")
                {
                    dgvUrunler.Rows[e.RowIndex].ErrorText = "Ürün ad boş geçilemez.";
                    e.Cancel = true;  // değişiimi iptal et. Boş string giremesin. Kabul etme
                }
                else
                {
                    dgvUrunler.Rows[e.RowIndex].ErrorText = "";
                }
            }
        }
    }
}
