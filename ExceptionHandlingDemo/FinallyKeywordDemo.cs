using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyNewProject1.ExceptionHandlingDemo
{
    class FinallyKeywordDemo
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                Console.WriteLine("Enter the number");
                int a = int.Parse(Console.ReadLine());
                sr = new StreamReader("D://a.txt");
                Console.WriteLine(sr.Read());
                Console.WriteLine(sr.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally //in case of error /No error then finally
            {
                Console.WriteLine(" in Finally");
                if (sr != null) 
                    sr.Close();
            }
            Console.ReadLine();
        }
    }
}
