using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAndTypes
{
    class findmethod
    {
        

    }
    class AsyncAndAwait
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Main method started");

//            findmethod obj=new findmethod();
           
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            //t1.IsBackground = true; 
            /////if it is forground thread then it will wait to execute until last logic
            t1.Start();
            t2.Start();

            Console.WriteLine("Main method ended");


        }

        public static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"method 1 iteration {i}");
            }
            Console.ReadLine();

        }

        public static void Method2()
        {


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"method 2 iteration {i}");
            }

        }


        class newofclass
        {
            public int MyProperty { get; set; }
        }
    }
}
