using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    public class Musteri
    {
        public string Mail { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public string Telefon { get; set; }
        Baglanti connect = new Baglanti();

        public void KisiEkle()
        {
            SqlCommand Ekle = new SqlCommand("insert into OtelBilgiSistemi.dbo.MusteriBilgi(MusteriAdi,MusteriSoyadi,Eposta,Sifre,Telefon) values (@p1,@p2,@p3,@p4,@p5)", connect.baglanti());
            Ekle.Parameters.AddWithValue("@p1", Ad);
            Ekle.Parameters.AddWithValue("@p2", Soyad);
            Ekle.Parameters.AddWithValue("@p3", Mail);
            Ekle.Parameters.AddWithValue("@p4", Sifre);
            Ekle.Parameters.AddWithValue("@p5", Telefon);
            Ekle.ExecuteNonQuery();
            connect.baglanti().Close();

        }

    }
}
