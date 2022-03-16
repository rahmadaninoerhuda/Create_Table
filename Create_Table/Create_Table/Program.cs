using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Koneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }

        public void Connecting()
        {
            using (
                SqlConnection con = new SqlConnection("data source=LAPTOP-I5CF3Q9T;" +
                "database=ProdiTI;User id=sa;Password=dedekgemes123")
                )
            {
                con.Open();
                Console.WriteLine("Berhasi Terhubung ke Database:");
            }
        }

        public void CreateTable()//Membuat Table
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection ("data source=LAPTOP-I5CF3Q9T;" +
                "database=ProdiTI;Integrated security = TRUE");
                con.Open();
                
                SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba (NIM char(12) not null primary key," +
                    "Nama Varchar (50), Alamat varchar(255), Jenis_Kelamin char(1))", con);//Command memmbuat atribut tabel
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel suksses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}


