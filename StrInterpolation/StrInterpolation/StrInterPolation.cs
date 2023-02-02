using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrInterpolation
{
    class StrInterPolation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st Number");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number");
            int num2=Convert.ToInt32(Console.ReadLine());

            int result=num1+ num2;
            Console.WriteLine("Addition of 1st number and seond number is "+result);


            //here we need another varible to store data but with use of interpolation now needed to store data separately 
            //memmory efficient for large volume data

            /*
            String result=$"Addittion of {num1} adn {num2} is {num1+ num2}";
            Console.WriteLine(result);
            */

        }
       
    }
}
