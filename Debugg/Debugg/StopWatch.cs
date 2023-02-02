using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndSpan
{
    class StopWatch
    {

        public static void Main(string[] args)
        {


            Console.WriteLine("===To start press 1===");
            var start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===Time Started===");   //Time started
            DateTime startTime = DateTime.Now;
            DateTime endTime;
            if (start == 1)
            {
                startTime = DateTime.Now;
            }

            var lapseList = new List<DateTime>();

            Console.WriteLine("+++++Press 2 for lapse or To Stop press 0+++++");

            var user = Convert.ToInt32(Console.ReadLine());
            if (user == 2)
            {
                lapseList.Add(DateTime.Now);
                Console.WriteLine($"=====Lap 1 {lapseList.Last() - startTime}===== ");
            }
            else if (user == 0)
            {
                endTime = DateTime.Now;
                Console.WriteLine("=====Time Stopped=====");

                Console.WriteLine($"===== Total Time Lapsed {endTime - startTime}=====");
                Environment.Exit(0);
            }

            Console.WriteLine("=====To stop press 0=====");
            endTime = DateTime.Now;
            var stop = Convert.ToInt32(Console.ReadLine());
            if (stop == 0)
                endTime = DateTime.Now;
            Console.WriteLine("------------");
            Console.WriteLine($" ======Total Time Lapsed {endTime - startTime}=======");

            Console.ReadLine(); 
        }
    }
}
