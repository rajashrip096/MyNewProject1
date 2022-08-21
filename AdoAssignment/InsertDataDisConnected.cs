﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyNewProject1.AdoAssignment
{
    class InsertDataDisConnected
    {
        static SqlDataAdapter sda = null;
        static DataSet ds = null;
        public static DataSet getAllStudents()
        {
            SqlConnection con = null;

            con = DBconnect.GetConnection();

            sda = new SqlDataAdapter("select * from student", con);
            //to assign primary key to col in dataset
            sda.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            ds = new DataSet();//Collection of tables
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
            Console.ReadLine();
        }
    }
}
