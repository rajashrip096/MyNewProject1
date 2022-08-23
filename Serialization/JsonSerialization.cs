using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace MyNewProject1.Serialization
{
    [Serializable]
    public class Student3
    {
        int rollno;
        string name;
        double percentage;

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public double Percentage { get => percentage; set => percentage = value; }
    }
    class JsonSerialization
    {
        static void JsonSerializationWrite(Student3 stud)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\FileFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Student3>(fs,stud);
              
                Console.WriteLine("Json data added");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\FileFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                Student3 stud = JsonSerializer.Deserialize<Student3>(fs);
                Console.WriteLine(stud.Rollno);
                Console.WriteLine(stud.Name);
                Console.WriteLine(stud.Percentage);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Student3 stud = new Student3 { Rollno = 101, Name = "Om", Percentage = 88.44 };
            JsonSerializationWrite(stud);
            JsonSerializationRead();
            Console.ReadLine();
        }
    }
}
