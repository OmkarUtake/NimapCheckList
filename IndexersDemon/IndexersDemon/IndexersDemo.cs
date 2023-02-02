using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersDemon
{
    class IndexersDemo
    {
        int id;
        String name, dept;
        public IndexersDemo(int id, String name, String dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }

        //if we have number of fields then we use indexer to work our class as a arrays indexing methods
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return id;
                else if (index == 2)
                    return name;
                else if (index == 3)
                    return dept;
                return null;
            }

        }
        public static void Main(String[] args)
        {
            IndexersDemo obj = new IndexersDemo(101, "Omkar", "dotnet");
            /*
            Console.WriteLine(obj.id);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.dept);
            */
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
            Console.WriteLine(obj[3]);
        }
    }
}
