using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassesEF
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Courselevel courselevel { get; set; }
        public float fullPrice { get; set; }
        public Author authod { get; set; }
        public List<Tag> tags { get; set; }

    }
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Course> courses { get; set; }

    }
    public class Tag
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Course> courses { get; set; }
    }
    public enum Courselevel
    {
        Begginer = 1,
        Intermediate = 2,
        Advance = 3
    }

    public class AlldetailsDB : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
