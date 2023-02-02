using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutwithMultipleReturn
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int q = 0;
            int r = 0;

            calc(num1, num2, out q, out r);
            Console.WriteLine(q + "+ " + r);

        }


        static void calc(int num1, int num2, out int reminder, out int quotient)
        {
            reminder = num1 / num2;
            quotient = num1 % num2;
        }

    }
}
