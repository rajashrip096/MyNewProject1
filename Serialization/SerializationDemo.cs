using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyNewProject1.Serialization
{
    //Add attribute on the top of the class ,This information will be pass to the CLR

    [Serializable]
    class Student
    {
        int rollno;
        string name;
        double percentage;

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public double Percentage { get => percentage; set => percentage = value; }
    }
    class SerializationDemo
    { 
        public static void BinarySerializationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\FileFolder\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, stud);
                Console.WriteLine("Binary data added");
                fs.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void BinarySerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Dotnetcore\FileFolder\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Student stud = (Student)bf.Deserialize(fs);
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
            Student stud = new Student { Rollno = 101, Name = "Rajashri", Percentage = 88.44 };
            BinarySerializationWrite(stud);
            BinarySerializationRead();
            Console.ReadLine();
        }
    }
}
