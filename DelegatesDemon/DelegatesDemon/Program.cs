
using System;
namespace GeeksForGeeks
{


    class Geeks
    {

        public void Add(int i,int j)
        {
            Console.WriteLine(i+j);
        }
        public void sub(int i, int j)
        {
            Console.WriteLine(i - j);
        }

        public delegate void myDelegate(int a, int b); 

        public static void Main(String[] args)
        {

            Geeks obj=new Geeks();

            myDelegate nobj = new myDelegate(obj.Add);
            nobj.Invoke(10, 20);
            nobj += obj.sub;
            nobj.Invoke(10,20);
            


        }
    }
}
