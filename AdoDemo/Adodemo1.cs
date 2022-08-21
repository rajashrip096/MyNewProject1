using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyNewProject1.AdoDemo
{
    class Adodemo1
    {
        static void Main(string[] args)
        {
            string str = "server=DESKTOP-IHKN692\\SQLEXPRESS;Database=HR;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                Console.WriteLine("Connection Established");
                con.Open();
                SqlCommand sqlcommand = new SqlCommand("select first_name,salary from employees", con);
                SqlDataReader dr = sqlcommand.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Name = " + dr["first_name"] + " Salary =" + dr[1]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            Console.ReadLine();
        }
    }
}
