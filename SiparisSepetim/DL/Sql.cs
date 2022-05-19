using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    // Data Acces Layer
    public class Sql
    {
        SqlConnection Baglanti = new SqlConnection();
        SqlCommand Komut = new SqlCommand();
        public Sql()
        {
            Baglanti.ConnectionString = @"Data Source=DESKTOP-ENMATP6\SQL_EXPRESS;Initial Catalog=SiparisDatabase;Integrated Security=SSPI;";
            Komut.Connection = Baglanti;
        }


        public void Execute(string Script)
        {
            Baglanti.Open();
            Komut.CommandText = Script;
            Komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        public DataTable ExecuteDatatable(string Script)  // Tablo okuma
        {
            DataTable dt = new DataTable();
            Baglanti.Open();  
            SqlDataAdapter sda = new SqlDataAdapter(Script,Baglanti);
            Baglanti.Close();
            sda.Fill(dt);  
            return dt;
        }
        public void addparameter(string row, object obje)  // Tabloya Ekleme Fonksiyonu
        {
            Komut.Parameters.AddWithValue(row, obje);
        }
        

        }







    }

