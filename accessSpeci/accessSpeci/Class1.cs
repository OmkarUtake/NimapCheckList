using System;
namespace accessSpeci
{
   public class parent
    {
        internal  void circleMethod()
        {
            Console.WriteLine("base method called");
        }
    }
    public class child : parent
    {
        internal  string circleMethod(string name)
        {
            Console.WriteLine("child Method Called");
            return name;
        }
    }
    public class implementation
    {
        public static void Main(String[] args)
        {

            child obj = new child();
            Console.WriteLine(obj.circleMethod("Omkar") ); 

        }


    }

}
