using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_OOP02
{
    class VeriTabani
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        string sorguCumlesi;
        DataTable dt;

        //ilk olarak bir veri tbanı bağlantısı yahpacak metod hazırlayın
        public SqlConnection Baglan()
        {

            string baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Kutuphane; User=sa; Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            //ctrl+K+D tabları hizalar
            return baglanti;
        }
        public void Kapat()
        {
            if (baglanti.State != ConnectionState.Closed)
            {
                baglanti.Close();
            }
        }
        public DataTable KayıtListele(string sorguCumlesi)
        {
            adaptor = new SqlDataAdapter(sorguCumlesi, Baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;
        }
        /*public void Ekle(string sorguCumlesi)
        {
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }*/
        public void Ekle(string sorguCumlesi,string turAd)
        {
            //bu metot insert update ve delete işlemlerini yapabilir.
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.Parameters.AddWithValue("@turAd", turAd);
            komut.ExecuteNonQuery();
            Kapat();
        }
        public void KitapEkle(string sorguCumlesi,List<string> g)
        {
            komut = new SqlCommand(sorguCumlesi, Baglan());

            komut.Parameters.AddWithValue("@p1", g[0]);
            komut.Parameters.AddWithValue("@p2", g[1]);
            komut.Parameters.AddWithValue("@p3", g[2]);
            komut.Parameters.AddWithValue("@p4", g[3]);
            komut.Parameters.AddWithValue("@p5", g[4]);
            komut.Parameters.AddWithValue("@p6", g[5]);
            komut.Parameters.AddWithValue("@p7", g[6]);
            komut.ExecuteNonQuery();
            Kapat();
        }
       /* public void Duzelt(string sorguCumlesi)
        {
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }*/
      /*  private void Sil(string TcNo, string Ad, string Soyad, string Cinsiyet, string Adres, string Telefon, string Mail, string ID)
        {
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }*/
        public bool KontrolEt(params string[] e)
        {
            bool donus = false;
            foreach (var item in e)
            {
                if (item=="")
                {
                    donus = false;
                    break;
                }
            }
            return donus;
        }
    }
}
