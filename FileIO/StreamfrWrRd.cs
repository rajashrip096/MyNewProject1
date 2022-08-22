using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyNewProject1.FileIO
{
    class StreamfrWrRd
    {
        static void WriteFilestream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\TestFolder\TextDoc1.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("This is Sample text ");
                sw.Close();
                sw.Close();
                Console.WriteLine("Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadFrUsingstream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\TestFolder\TextDoc1.txt", FileMode.Open, FileAccess.Read);
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
            WriteFilestream();
            ReadFrUsingstream();
            Console.ReadLine();
        }
    }
}
