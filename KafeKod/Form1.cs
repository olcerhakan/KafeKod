using KafeKod.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            VerileriOku();            
            InitializeComponent();
            MasalariOlustur();
            
        }

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                db = JsonConvert.DeserializeObject<KafeVeri>(json);
            }
            catch (Exception)
            {

                db = new KafeVeri();
            }
        }

        //private void OrnekVerileriYukle()
        //{
        //    db.Urunler = new List<Urun>
        //    {
        //        new Urun { UrunAd = "Kola", BirimFiyat = 4.90m },
        //        new Urun { UrunAd = "Çay", BirimFiyat = 2.95m }
        //    };
        //    db.Urunler.Sort();   // Ürün class ında IComparable yaptığımız için artık sort yapabilirz
        //}

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
                // i masano değeri ile kayıtlı bir sipariş var mı ? bu getir ilkini bulamazsan defaultu siparişlerden masa no i olan varmı ?
                Siparis sip = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == i);
                //Siparis sip = null;
                //foreach (Siparis item in db.AktifSiparisler)
                //{
                //    if (x.MasaNo ==i )
                //    {
                //        sip = x;
                //        break;
                //    }
                //}
                if (sip ==null)
                {

                lvi.Tag = i;
                lvi.ImageKey ="bos";
                }
                else
                {
                    lvi.Tag = sip;
                    lvi.ImageKey = "dolu";
                }
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

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            var frm = new UrunlerForm(db);
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           string json= JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }
    }
}
