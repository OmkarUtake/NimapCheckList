using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDemon
{

    class TPL
    {
        public static void Main(string[] args)
        {
            DateTime start=DateTime.Now;

            Thread t1 = new Thread(loop);
            t1.Start();

           // Parallel.For(0,10,x=>loop());
            DateTime end = DateTime.Now;
            Console.WriteLine($"{end-start}");

            Console.ReadLine();
        }
        public static void loop() {
            int count=0;
            for(int i=0;i<10;i++)
            {
                count++;
                Console.WriteLine(count);
            }
        }
    }
}
