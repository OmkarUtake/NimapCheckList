using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class AsyncAndAwait
    {
        static void Main(string[] args)
        {
            method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }

        public static async void method()
        {
            Console.WriteLine("Before Sleep");
            await Task.Run(new Action(LongTask));
            Console.WriteLine("After Sleep");
        }

        public static void LongTask()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Long Task Method");
        }
    }
}
