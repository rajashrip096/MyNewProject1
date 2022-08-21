using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyNewProject1.AdoAssignment
{
    //5.Write a C# program to add a record to database?
    //Accept data from console and insert.(Disconnected architecture)?

    class InsertDatafrDisconnected
    {
        static SqlDataAdapter sda = null;
        static DataSet ds = null;
        public static DataSet getAllStudents()
        {
            SqlConnection con = null;

            con = DBconnect.GetConnection();

            sda = new SqlDataAdapter("select * from student", con);
            
            sda.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            ds = new DataSet();
            sda.Fill(ds);

            return ds;
        }
        static public void AddStudent()
        {
            Console.WriteLine("Enter id,nm,marks");
            int id = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int mks = int.Parse(Console.ReadLine());

            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = id;
            dr[1] = nm;
            dr[2] = mks;
            ds.Tables[0].Rows.Add(dr);
           int result= sda.Update(ds);
            Console.WriteLine(result > 0 ? "Record inserted " : "Not");
         
        }
          
        public static void showAllStudent()
        {
                getAllStudents();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
                }

        }
            static void Main(string[] args)
            {
                getAllStudents();
                AddStudent();
               showAllStudent();

                Console.ReadLine();
            }
    }
}
