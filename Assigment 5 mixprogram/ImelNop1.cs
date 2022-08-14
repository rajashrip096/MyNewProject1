using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject1.Assigment_5_mixprogram
{
    //1.An IMEI number/ International Mobile Station Equipment Identity is a 15 digit number
    //and it is said to be IMEI number if and only if the sum of the number is exactly divisible by 10.

    /*The IMEI(15 decimal digits: 14 digits plus a check digit) includes information on the origin, model, and serial number of the device.

   The IMEI number is used by a GSM network to identify valid devices and therefore can be used for stopping a stolen phone from accessing that network
   The IMEI is validated in following steps:
1.	Starting from the rightmost digit, double the value of every second digit (e.g., 7 becomes 14).
2.	If doubling of a number results in a two digits number i.e greater than 9(e.g., 7 × 2 = 14), 
    then add the digits of the product(e.g., 14: 1 + 4 = 5), to get a single digit number.
3.	Now take the sum of all the digits.
4.	Check if the sum is divisible by 10 i.e.(total modulo 10 is equal to 0) then the IMEI number is valid; else it is not valid.*/

//Input IMEI : 490154203237518
//Output : Since, 60 is divisible by 10, hence the given IMEI number is Valid.

    class ImelNop1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the IMEI no");
            long num = long.Parse(Console.ReadLine());
            long sum = 0;
            int count = 1;
            for (long i = num; i > 0; i = i / 10)
            { 
                long fact = i % 10;
                
                if (count % 2 == 0)
                {
                    fact = fact * 2; 
                }

                long add = 0;

                for (long j = fact; j > 0; j = j / 10)
                {
                    long rem = (j % 10);
                    add = add + rem;
                }
                sum = sum + add;
                count++;
            }
            if (sum % 10== 0)
            {
                Console.WriteLine("IMEI is Valid");
            }
            else
            {
                Console.WriteLine("IMEI Not Valid");
            }
            Console.ReadLine();
        }
    }
}
