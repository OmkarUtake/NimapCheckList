using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorAndNumerable
{
    class NumerableVsNumerator
    {
        public static void Main(String[] args)
        {
            var dateList = new List<DateTime>();

            dateList.Add(DateTime.Today);
            dateList.Add(DateTime.Today.AddDays(1));
            dateList.Add(DateTime.Today.AddDays(2));
            dateList.Add(DateTime.Today.AddDays(3));
            dateList.Add(DateTime.Today.AddDays(4));
            dateList.Add(DateTime.Today.AddDays(5));
            dateList.Add(DateTime.Today.AddDays(6));

            IEnumerable<DateTime> ienum = (IEnumerable<DateTime>)dateList;
            foreach(object dat in ienum)
            {
                Console.WriteLine(dat.ToString());
            }

            IEnumerator<DateTime> it = (IEnumerator<DateTime>)dateList.GetEnumerator();
            {
                int count = 0;
                while (it.MoveNext())
                {
                    count++;
                    
                    Console.WriteLine(it.Current);
                    if (count > 2)
                    {
                        break; 
                    }
                }
            }
            Console.WriteLine("Out from Loop");
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current);
            }


            ////Enumerable
            //int ctr = 0;
            //IEnumerable<DateTime> enumerable = (IEnumerable<DateTime>)dateList;
            //foreach (Object date in enumerable)
            //{
            //    ctr++;

            //    Console.WriteLine(date);
            //    if (ctr > 2)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Out from first Loop");
            //foreach(Object date in enumerable)
            //{
            //    Console.WriteLine(date);
            //}

            ////using Enumerator
            //IEnumerator<DateTime> enumerator = dateList.GetEnumerator();
            //int count = 0;
            //while (enumerator.MoveNext())
            //{
            //    count++;
            //    Console.WriteLine(enumerator.Current);

            //    if (count > 2)
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine("Out from first Loop");
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}




        }
    }
}
