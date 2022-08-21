using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyNewProject1.AdoDemo
{
    class DisConnected
    {
        public static DataSet getAllStudents()
        {
            SqlConnection con = null;

            con = DBconnect.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from student", con);
            DataSet ds = new DataSet();//Collection of table

            sda.Fill(ds, "student");

            return ds;
        }
        static void Main(string[] args)
        {
            DataSet ds = getAllStudents();
            foreach (DataRow dr in ds.Tables["student"].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
            Console.ReadLine();
        }
    }
}
