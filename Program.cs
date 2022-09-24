using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
           string connectionString = "Data Source=BTECH1807169\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True";
           Console.WriteLine("enter the publication id to search the books for:");
            string pubid =Console.ReadLine();
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from titles where pub_id='" + pubid + "'", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr["title_id"]);
                Console.WriteLine(dr["title"]);
                Console.WriteLine(dr["type"]);
                Console.WriteLine(dr["pub_id"]);
                Console.WriteLine(dr["price"]);
                Console.WriteLine("----------------------");
            }
            cn.Close();
            Console.Read();
        }
    }
}
