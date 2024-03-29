﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyNewProject1.FileIO
{
    //Write a code to accept string from user & write to file using Stream writer & read & display on console
   class AssignmtSteamWrRd
    {
        static void WriteToFilestream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\TestFolder\TextDoc.txt", FileMode.Create,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("This is Sample text in the File");
                sw.Close();
                sw.Close();
                Console.WriteLine("Done");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadFromUsingstream()
        {
            try
            { 
                FileStream fs = new FileStream(@"E:\Dotnetcore\TestFolder\TextDoc.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            WriteToFilestream();
            ReadFromUsingstream();
            Console.ReadLine();
        }
    }
}
