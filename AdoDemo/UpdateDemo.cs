using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyNewProject1.AdoDemo
{
    class DBconnect2
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
    class UpdateDemo
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBconnect.GetConnection();
            SqlCommand cmd = new SqlCommand("update student set sname='Navin' where sname='Ram'", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record Updated");
            Console.ReadLine();
        }
    }
}
