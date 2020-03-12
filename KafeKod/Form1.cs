﻿using KafeKod.Data;
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
        KafeContext db = new KafeContext();


        public Form1()
        {
                       
            InitializeComponent();
            MasalariOlustur();
            
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

            lvwMasalar.Items.Clear();
            ListViewItem lvi;
            for (int i = 1; i <= Properties.Settings.Default.MasaAdet; i++)
            {
                lvi = new ListViewItem("Masa " + i);
                // i masano değeri ile kayıtlı bir sipariş var mı ? bu getir ilkini bulamazsan defaultu siparişlerden masa no i olan varmı ?
                Siparis sip = db.Siparisler.FirstOrDefault(x => x.MasaNo == i && x.Durum == SiparisDurum.Aktif);
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
                    sip.Durum = SiparisDurum.Aktif;
                    sip.MasaNo = (int)lvi.Tag;
                    sip.AcilisZamani = DateTime.Now;
                    lvi.Tag = sip;
                    db.Siparisler.Add(sip);
                    db.SaveChanges();
                }
                SiparisForm frmSiparis = new SiparisForm(db,sip);
                frmSiparis.MasaTasiniyor += FrmSiparis_MasaTasindi;
                frmSiparis.ShowDialog();

                if (sip.Durum ==SiparisDurum.Odendi || sip.Durum == SiparisDurum.Iptal)
                {
                    lvi.Tag = sip.MasaNo;
                    lvi.ImageKey = "bos";
                    
                }

            }
        }

        private void FrmSiparis_MasaTasindi(object sender, MasaTasimaEventArgs e)
        {
            //adım1 : eski masayı boşalt
            ListViewItem lviEskiMasa = MasaBul(e.EskiMasaNo);
            lviEskiMasa.Tag = e.EskiMasaNo;
            lviEskiMasa.ImageKey = "bos";
            //adım2 : yeni masaya siparişi koy

            ListViewItem lviYeniMasa = MasaBul(e.YeniMasaNo);
            lviYeniMasa.Tag = e.TasinanSiparis;
            lviYeniMasa.ImageKey = "dolu";

        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            var frm = new GecmisSiparislerForm(db);
            frm.ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            var frm = new UrunlerForm(db);
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private ListViewItem MasaBul(int masaNo)
        {
            foreach (ListViewItem item in lvwMasalar.Items)
            { 
                if (item.Tag is int && (int)item.Tag ==masaNo )
                {
                    return item;
                }
                else if(item.Tag is Siparis && ((Siparis)item.Tag).MasaNo == masaNo)  // siparişse ve o siparişin tag ını siparişe çevrildikten sorna masaano ya eşitse bul
                {
                    return item;
                }
            }
            return null;
        }

        private void tsmiAyarlar_Click(object sender, EventArgs e)
        {
            var frm = new AyarlarForm();
            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                MasalariOlustur();
            }
        }
    }
}
