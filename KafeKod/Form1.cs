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
    public partial class Form1 : Form
    {
        KafeVeri db;
        int masaAdet = 20;
        
        public Form1()
        {
            db = new KafeVeri();
            OrnekVerileriYukle();
            InitializeComponent();
            MasalariOlustur();
            
        }

        private void OrnekVerileriYukle()
        {
            db.Urunler = new List<Urun>
            {
                new Urun { UrunAd = "Kola", BirimFiyat = 4.90m },
                new Urun { UrunAd = "Çay", BirimFiyat = 2.95m }
            };
        }

        private void MasalariOlustur()
        {
            #region ListView Imajlarının Hazırlanması
            ImageList il = new ImageList();
            il.Images.Add("bos", Properties.Resources.masabos1);
            il.Images.Add("dolu", Properties.Resources.masadolu2);
            il.ImageSize = new Size(69,69);
            lvwMasalar.LargeImageList = il;

            #endregion

            ListViewItem lvi;
            for (int i = 1; i <= masaAdet; i++)
            {
                lvi = new ListViewItem("Masa " + i);
                lvi.Tag = i;
                lvi.ImageKey ="bos";
                lvwMasalar.Items.Add(lvi);

            }
        }

        private void lvwMasalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var lvi = lvwMasalar.SelectedItems[0];  //lv item ın ilki dediğimiz için, var ListViewItem oldugunu anladı.
                lvi.ImageKey = "dolu";

                Siparis sip;
                // Masa doluysa olanı al, boşsa yeni oluştur.
                if(lvi.Tag is Siparis)     //boşken yeni açarken masa tag = int. else e düşer.
                {
                    sip = (Siparis)lvi.Tag;
                }
                else
                {
                    sip = new Siparis();
                    sip.MasaNo = (int)lvi.Tag;
                    sip.AcilisZamani = DateTime.Now;
                    lvi.Tag = sip;
                    db.AktifSiparisler.Add(sip);
                }
                SiparisForm frmSiparis = new SiparisForm(db,sip);
                frmSiparis.ShowDialog();

                if (sip.Durum ==SiparisDurum.Odendi || sip.Durum == SiparisDurum.Iptal)
                {
                    lvi.Tag = sip.MasaNo;
                    lvi.ImageKey = "bos";
                    db.AktifSiparisler.Remove(sip);
                    db.GecmisSiparis.Add(sip);
                }

            }
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            var frm = new GecmisSiparislerForm(db);
            frm.Show();
        }
    }
}
