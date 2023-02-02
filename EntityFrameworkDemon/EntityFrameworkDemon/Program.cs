using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemon
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string city { get; set; }
    }

    public class DBConfig : DbContext
    {
        public DbSet<Student> students { get; set; }
    }

    public class Program
    {
        public static void Main(String[] args)
        {

        }
    }
}
