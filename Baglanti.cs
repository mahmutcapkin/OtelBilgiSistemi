using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace OtelBilgiSistemi
{
    public class Baglanti
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-H28HIJ5\SQLEXPRESS;Initial Catalog=OtelBilgiSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }



























        /* SqlConnection baglanti = new SqlConnection(;

         private readonly String _connectionString;

         public Baglanti()
         {
             _connectionString = @"Data Source=DESKTOP-H28HIJ5\SQLEXPRESS;Initial Catalog=OtelBilgiSistemi;Integrated Security=True";
         }

         private SqlConnection GetSqlConnection()
         {
             SqlConnection connection = new SqlConnection(_connectionString);
             if(connection.State==ConnectionState.Open)
             {
                 connection.Close();
                 connection.Open();
             }
             else
             {
                 connection.Open();

             }
             return connection;
         }

         public SqlCommand GetSqlCommand()
         {
             SqlCommand komut = new SqlCommand();
             komut.Connection = GetSqlConnection();
             return komut;
         }*/

    }
}

