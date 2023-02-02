using System.Linq;
using System;
namespace Queries
{
    class baseclass
    {
        public void method()
        {
            Console.WriteLine("base");
        }
    }
    class child : baseclass
    {
        public void method()
        {
            Console.WriteLine("child");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var context = new PlutoContext();


            //LINQ using Syntaxt
            var group =
                from c in context.Courses
                where c.Name.Contains("c#")
                select c;

            //using Extension method
            var cd =
                context.Courses.Where(c => c.Name.Contains("c#"));


        }
    }
}
