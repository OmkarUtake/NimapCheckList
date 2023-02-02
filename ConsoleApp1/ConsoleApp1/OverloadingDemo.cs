using System;

namespace OverloadingDemo
{
    public class OverloadingDemo
    {
        const float pi = 3.14f;
        static void Area(int a)
        {
            Console.WriteLine("Single parameter");
            Console.WriteLine(a*a);

        }
        //overloading with diff number of parameters
        static void Area(int a, int b)
        {
            Console.WriteLine("Overloaded with multi parameter");
            Console.WriteLine(a * b);

        }
        //overloading with chaning type of parameters
        static void Area(float r,int height)
        {
            Console.WriteLine("Overloaded with diff types of parameter");
            Console.WriteLine(r*height);

        }


        //use of param keyword when we dont know how many parameters will be there in method
        public static int Add(params int[] arr)
        {
            int total = 0;
            foreach(var num in arr)
            {
                total=total+num;
            }
            return total;
        }

        public static void Main(string[] args)
        {


          var result= Add(1, 2, 3, 4);
            Console.WriteLine(result);

            Area(5);
            Area(2.5f, 10);
            Area(10, 20);

        }
    }
}
