using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kutuphane_OOP02
{
    class Kutuphane
    {
       
    }

    public class Turler //tblTurler
    {
        private int id;

        public int ID //ID alanı
        {
            get { return id; }
            //set { id = value; } //dışardab grişi engllemek için kapattık
        }
       
        private string turAd;

        public string TurAd
        {
            get { return turAd; }
            set 
            {
                turAd = value.ToUpper();
            }
        }

    }

    public class YayinEvleri //tblYazarlar
    {
        private int id;

        public int ID
        {
            get { return id; }
        }
        public string YayinAd { get; set; }
        public string YayinAdres { get; set; }
        public string YayinTel { get; set; }

    }
    public class Kisiler
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }

    }
    public class Uyeler : Kisiler
    {
        public Uyeler()
        {
            CezaDurumu = false;
        }
        public enum UTip
        {
            Standart,
            Elit
        }
        public enum EDTip
        {
            IlkOkul_Mezunu,
            OrtaOkul_Mezunu,
            LiseMezunu,
            UniversiteMezunu,
            Ogrenci
        }
        public DateTime UyelikTarihi { get; set; }
        public UTip UyelikTipi { get; set; }
        public string TCNo { get; set; }
        public string Meslek { get; set; }
        public EDTip EgitimDurumu { get; set; } //revize edilecek
        public bool CezaDurumu { get; set; }


    }
    public class Yazarlar : Kisiler //tblYazarlar
    {
        public int TurID { get; set; } //yazarın ön plana çıktığı tür bilgisi

    }
    public class Kitaplar
    {
        public string ISBN { get; set; }
        public string KitapAd { get; set; }
        public int SayfaSayisi { get; set; }
        public int StokAdedi { get; set; }
        public int TurID { get; set; }
        public int YazarID { get; set; }
        public int YayinEviID { get; set; }
    }
    public class Odunc
    {
        private int id;

        public int ID
        {
            get { return id; }
        }

        public int UyeID { get; set; }
        public int KitapISBN { get; set; }
        public DateTime OduncTarihi { get; set; }
        public DateTime TeslimTarih { get; set; }
        public bool Iptal { get; set; }

    }
}
