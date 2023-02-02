using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemonstratation
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
    }

    public class DbConfigContext : DbContext
    {
        public DbSet<Student> students { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
