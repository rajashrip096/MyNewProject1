using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyNewProject1.AdoAssignment
{
    //2.Write a C# program to add a record to database?
    //Accept data from console and insert.(Connected architecture)?
    class DBconnect
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
    class Program2Insertdata
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBconnect.GetConnection();
            Console.WriteLine("Enter id ,name,marks");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("insert into Student values(@id,@name,@marks)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@marks", marks);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record inserted");
            Console.ReadLine();
        }
    }
}
