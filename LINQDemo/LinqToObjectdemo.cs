using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.LINQDemo
{

    class Product
    {
        int id;
        string name;
        int price;
        string companyname;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Companyname { get => companyname; set => companyname = value; }

        public override string ToString()
        {
            return $"{Id}-> {Name}->{Price}->{Companyname}";
        }
    }
    class LinqToObjectdemo
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=699,Companyname="Dell"},
                new Product{Id=2,Name="Mouse",Price=899,Companyname="Lenove"},
                new Product{Id=3,Name="Laptop",Price=34699,Companyname="Dell"},
                new Product{Id=4,Name="Laptop",Price=45699,Companyname="Hp"},
                new Product{Id=5,Name="KeyBoard",Price=2699,Companyname="Dell"},
                new Product{Id=6,Name="KeyBoard",Price=1699,Companyname="Hp"},
                new Product{Id=7,Name="RAM 4GB",Price=3699,Companyname="Intel"},
                new Product{Id=8,Name="Speaker",Price=2699,Companyname="Microsoft"},
                new Product{Id=9,Name="Speaker",Price=1699,Companyname="Sony"},
                new Product{Id=10,Name="USB Mouse",Price=1699,Companyname="Dell"},
            };
            var result = from p in prod
                         select p;

            var result1 = from p in prod
                          where p.Price<2000
                         select p;

            var result2 = from p in prod
                          where p.Price > 2000 && p.Price<3000
                          select p;

            var result3 = from p in prod
                          where p.Companyname.StartsWith("D")
                          select p;
            var result4 = from p in prod
                          where p.Companyname.EndsWith("l")
                          select p;

            var result5 = from p in prod
                          where p.Companyname.Contains("m") || p.Companyname.Contains("M")
                          select p;

            var result6 = from p in prod
                          where p.Price > 2000
                          orderby p.Name descending
                          select p;
            // Lambda expression
            var res = prod.Where(p => p.Price < 2000).ToList();
            var res2 = prod.Where(p => p.Price > 2000).OrderBy(x => x.Name).ToList();
            // retrive single record
            var res4 = prod.Where(x => x.Id == 1).SingleOrDefault();
            var res3 = prod.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Take(3);

            var res5 = prod.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Skip(3);


            foreach (Product item in res5)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
