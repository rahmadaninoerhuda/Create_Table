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
            new Program().Connecting();
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
    }
}


