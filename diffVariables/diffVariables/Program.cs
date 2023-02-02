using System;
using System.Reflection.PortableExecutable;

namespace MyApp
{


    class newProgram : Program
    {
        public override void Version()
        {
            Console.WriteLine("version ");
        }
        static void Main(string[] args)
        {

            newProgram obj = new newProgram();
            int j = obj.i;
            Console.WriteLine(j);
        }
    }

    abstract class Program
    {
        public int i;
        public abstract void Version();
        static void abs()
        {

        }

    }

}