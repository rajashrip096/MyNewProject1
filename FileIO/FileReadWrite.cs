using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyNewProject1.FileIO
{
    public class Dept
    {
        int id;
        string name;
        string location;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
    }
    class FileReadWrite
    {
        static void WritetoFile(Dept dept)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\TestFolder\TextFile", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(dept.Id);
                bw.Write(dept.Name);
                bw.Write(dept.Location);
                fs.Close();
                bw.Close();
                Console.WriteLine("File is create");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ReadFromFile()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\TestFolder\TextFile", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadString());
                fs.Close();
                br.Close();
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Dept dept = new Dept { Id = 1, Name = "HR", Location = "Pune" };
            WritetoFile(dept);
            ReadFromFile();
            Console.ReadLine();
        }
    }
}
