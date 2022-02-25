using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kutuphane_OOP02
{
    public partial class FormKutuphane : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormKutuphane()
        {
            InitializeComponent();
        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            pnlTeslimTarihi.Visible = false;
            VeriTabani veriTabani = new VeriTabani();
        }

        private void btnKYeni_Click(object sender, EventArgs e)
        {
            Turler yeniTur = new Turler();
            yeniTur.TurAd = txtKitapTurAd.Text;
            string sorguCumlesi =$"INSERT INTO tblTurler VALUES(@turAd)";
            vt.Ekle(sorguCumlesi,yeniTur.TurAd);
        }

        private void btnYeniKitap_Click(object sender, EventArgs e)
        {
            Kitaplar YeniKitap = new Kitaplar();
            YeniKitap.KitapAd = txtKitapAd.Text;
            YeniKitap.ISBN =txtKitapISBN.Text;
            YeniKitap.SayfaSayisi =int.Parse(txtSyfSayi.Text);
            YeniKitap.StokAdedi =int.Parse(txtStok.Text);
            YeniKitap.TurID = int.Parse(cmbKTur.Text);
            YeniKitap.YazarID = int.Parse(cmbYazar.Text);
            YeniKitap.YayinEviID = int.Parse(cmbYayinEv.Text);

            List<string> gonderilecek = new List<string>();

            gonderilecek.Add(YeniKitap.ISBN);
            gonderilecek.Add(YeniKitap.KitapAd);
            gonderilecek.Add(YeniKitap.SayfaSayisi.ToString());
            gonderilecek.Add(YeniKitap.StokAdedi.ToString());
            gonderilecek.Add(YeniKitap.TurID.ToString());
            gonderilecek.Add(YeniKitap.YazarID.ToString());
            gonderilecek.Add(YeniKitap.YayinEviID.ToString());


            string sorguCumlesi = $"INSERT INTO tblKitaplar (ISBN,kitapAd,sayfaSayi,stok,kitapTur,yazar,yayınEv) VALUES(@ISBN,@kitapAd,@sayfaSayi,@stok,@kitapTur,@yazar,@yayınEv)";
            vt.KitapEkle(sorguCumlesi, gonderilecek);
        }

        
    }
}
