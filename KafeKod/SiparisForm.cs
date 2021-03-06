﻿using KafeKod.Data;
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
    public partial class SiparisForm : Form
    {
        public event EventHandler<MasaTasimaEventArgs> MasaTasiniyor;

        KafeVeri db;
        Siparis siparis;
        BindingList<SiparisDetay> blSiparisDetaylar;
        public SiparisForm(KafeVeri kafeVeri, Siparis siparis)
        {
            db = kafeVeri;
            this.siparis = siparis;
            blSiparisDetaylar =
                new BindingList<SiparisDetay>(siparis.SiparisDetaylar);
            InitializeComponent();
            MasaNoGuncelle();
            MasaNolariYukle();
            TutarGuncelle();
            cboUrun.DataSource = db.Urunler;  //.OrderBy(x=> x.UrunAd).ToList();   //Ürünleri sıralı getirme.
            cboUrun.SelectedItem = null;
            dgvSiparisDetaylari.DataSource = blSiparisDetaylar;  // data grid view e UrunAD BirimFiyat getirme
        }

        private void MasaNolariYukle()
        {
            cboMasaNo.Items.Clear();
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                if ( !db.AktifSiparisler.Any(x=> x.MasaNo ==i))
                {
                   cboMasaNo.Items.Add(i);
                }
            }
        }

        private void TutarGuncelle()
        {
            lblTutar.Text = siparis.ToplamTutarTL;
        }

        private void MasaNoGuncelle()
        {
            Text ="Masa "+ siparis.MasaNo;
            lblMasaNo.Text = siparis.MasaNo.ToString("00");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cboUrun.SelectedItem ==null)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz !!");
                return;
            }

            Urun SeciliUrun = (Urun)cboUrun.SelectedItem;
            var sipdetay = new SiparisDetay
            {
                UrunAd = SeciliUrun.UrunAd,
                BirimFiyat = SeciliUrun.BirimFiyat,
                Adet = (int)nudAdet.Value
            };
            blSiparisDetaylar.Add(sipdetay);
            cboUrun.SelectedItem = 0;
            nudAdet.Value = 1;
            TutarGuncelle();
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(
                "Sipariş iptal edilecektir.! Onaylıyor musunuz ? ",
                "Sipariş Onayı", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                siparis.Durum = SiparisDurum.Iptal;
                siparis.KapanisZamani = DateTime.Now;
                Close();
            }
            siparis.Durum = SiparisDurum.Iptal;

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(
               "Ödeme alındıysa masa sonlandırılacaktır.! Onaylıyor musunuz? ",
               "Masa Kapatma Onayı",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button2);
            
            if (dr == DialogResult.Yes)
            {
                siparis.Durum = SiparisDurum.Odendi;
                siparis.KapanisZamani = DateTime.Now;
                siparis.OdenenTutar = siparis.ToplamTutar();
                Close();
            }
            siparis.Durum = SiparisDurum.Odendi;
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls )
            {
                if (ctrl != sender)  // veya if(ctrl != btnGizle)
                {
                    // ctrl.Hide();
                    System.Threading.Thread.Sleep(150);
                    ctrl.Visible = !ctrl.Visible;
                }
            }
        }

        // MOUSE LA SAĞ TUŞTAN MENUDEN SİLSİN
        private void dgvSiparisDetaylari_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               
                int rowIndex = dgvSiparisDetaylari.HitTest(e.X, e.Y).RowIndex;   //Satırın indexi bulunur
                if (rowIndex> -1)
                {
                //butun mavilikler bulunur temizlenir
                dgvSiparisDetaylari.ClearSelection();
                dgvSiparisDetaylari.Rows[rowIndex].Selected = true;   //mousenin seçili oldugu satır true yapılır
                cmsSiparisDetay.Show(MousePosition);


                }

            }
        }

        private void tsmiSiparisDetaySil_Click(object sender, EventArgs e)
        {
            //secili elemanı sil
            if (dgvSiparisDetaylari.SelectedRows.Count>0)
            {
                var seciliSatir = dgvSiparisDetaylari.SelectedRows[0];
                var sipDetay = (SiparisDetay)seciliSatir.DataBoundItem;  //o satırdaki görünen sipariş detayı
                blSiparisDetaylar.Remove(sipDetay);
            }

            TutarGuncelle();
        }

        private void btnMasaTasi_Click(object sender, EventArgs e)
        {
            if (cboMasaNo.SelectedItem == null)
            {
                MessageBox.Show("Lütfen taşınacak masa numarası seçiniz !");
                return;
            }
            int eskiMasaNo = siparis.MasaNo;
            int hedefMasaNo = (int)cboMasaNo.SelectedItem;

            if (MasaTasiniyor != null)
            {
                var args = new MasaTasimaEventArgs
                {
                    TasinanSiparis = siparis,
                    EskiMasaNo = eskiMasaNo,
                    YeniMasaNo = hedefMasaNo
                };
                MasaTasiniyor(this, args);
            }

            siparis.MasaNo = hedefMasaNo;
            MasaNoGuncelle();
            MasaNolariYukle();

           

        }
    }

    public class MasaTasimaEventArgs : EventArgs
    {
        public Siparis TasinanSiparis { get; set; }
        public int EskiMasaNo { get; set; }
        public int YeniMasaNo { get; set; }
    }
}
