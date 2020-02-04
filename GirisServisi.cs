using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtelBilgiSistemi
{
    public class GirisServisi
    {
        public  bool KullaniciUyeDogrula(string kullaniciAdi, string sifre) // Üye adi şifre kontrolü
        {
            Baglanti connect  = new Baglanti();

            SqlCommand komut = new SqlCommand("Select * From MusteriBilgi where Eposta =@p1 and Sifre = @p2", connect.baglanti());
            komut.Parameters.AddWithValue("@p1",kullaniciAdi);
            komut.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}

