using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Oops
{
    // create shopping class contain purchase item,prize per item,quantity.
    //1.create first method to accept shopping details 
    //2.if quantity > othen calculate the bill for purchase item using get bill method,otherwise show the error
    //3.create 3rd method to show total bill including all shopping dsetails.
    class Shopping
    {
        string item;
        int prize;
        int quantity;
        int total;
        public void Accept(string sitem,int sprize,int squantity )
        {
            item = sitem;
            prize = sprize;
            quantity = squantity;
        }
        public void get()
        {
            
            if(quantity>0)
            {
                total = quantity * prize;
                Console.WriteLine("Total is " +total);
                
            }
            else
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
        }
        public void Show()
        {
            Console.WriteLine("item is " + item);
            Console.WriteLine("prize is "+prize);
            Console.WriteLine("quantity is"+quantity);
            Console.WriteLine("Total is " +total);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.Accept("mobile", 20, 2);
            s.get();
            s.Show();
        }
    }
}
