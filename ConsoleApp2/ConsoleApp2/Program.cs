using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            baseClass obj = new childClass();
            obj.add();
        }
    }
    class baseClass
    {
        public virtual void add()
        {
            Console.WriteLine("Not loaded from base");
        }
    }
    class childClass : baseClass
    {
        public override void add()
        {
            Console.WriteLine("child loaded");
        }
    }
}