using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
     class Dynamic
    {
        public static void Main(String[] args)
        {
            //int i = 10;
            //i = "10";
            var k = 10;
            k = Convert.ToInt32(Console.ReadLine());   //if we use var the variable type is fixed 
            Console.WriteLine(k);



            dynamic i = 10;   //if we use dynamic vaiable type can change as per data asigne to it;
            Console.WriteLine("Input the values");
            i = Console.ReadLine();
            Console.WriteLine(i);




            object j = 10;
            Console.WriteLine( j.GetType());

        }
    }
}
