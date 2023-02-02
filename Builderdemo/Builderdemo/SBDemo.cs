using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builderdemo
{
    class SBDemo
    {
        public static void Main(String[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Beore appending : " +sb.GetHashCode());
            sb.Append("Appended");
            Console.WriteLine("After appending : " + sb.GetHashCode());

            string newString = "hello";
            Console.WriteLine("Beore Concating : " + newString.GetHashCode());
            newString = string.Concat(" World");
            Console.WriteLine("After Concating : " + newString.GetHashCode());


        }

    }
}
