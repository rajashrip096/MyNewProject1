using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyNewProject1.FileIO
{
   class AssignmtSteamWrRd
    {
        static void WriteToFilestream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\TestFolder\TextFile.txt", FileMode.Create,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("This is Sample text in the File");
                sw.Close();
                sw.Close();
                Console.WriteLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
