using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyNewProject1.AdoDemo
{
    class DBconnect1
    {
        public static SqlConnection GetConnection()
        {
            string str = "server=DESKTOP-IHKN692\\SQLEXPRESS;Database=HR;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }

    }
    class DemoDelete
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBconnect1.GetConnection();
            SqlCommand cmd = new SqlCommand("delete from Student where sname='Siya'", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record Deleted");
            Console.ReadLine();
        }
    }
}
