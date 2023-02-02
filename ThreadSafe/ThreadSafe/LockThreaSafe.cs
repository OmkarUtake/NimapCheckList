using System;
using System.Threading.Tasks;

namespace ThreadSafe
{
    class LockThreaSafe
    {
        public static void Main(String[] args)
        {
            LockThreaSafe lt = new LockThreaSafe();

            Thread t1 = new Thread(lt.divide);
            t1.Start();
            lt.divide();

        }

        public int num1, num2;


        Random rd = new Random();
        void divide()
        {

            for (long i = 0; i < 10000000; i++)
            {
                lock (this)
                {
                    num1 = rd.Next(1, 2);
                    num2 = rd.Next(1, 2);
                    int res = num1 / num2;
                    Console.WriteLine(res);
                    num1 = 0;
                    num2 = 0;
                }


            }
        }
    }
}
