using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDmo
{

    public class Students
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string LastName { get; set; }
        public virtual List<Course> courses { get; set; }
    }

    public class Course
    {
        public int id { get; set; }
        public string course1 { get; set; }
        public string course2 { get; set; }
        public string course3 { get; set; }
        public string course4 { get; set; }


    }

    public class StudentDbContext : DbContext
    {

        public DbSet<Students> studentDetails { get; set; }
        public DbSet<Course> courseDetails { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var context = new StudentDbContext();
            var data = context.studentDetails.Single(x => x.id == 2);

            //to eager loading use 
            //Include(c=>c.courses).Single(a=>a.id==1)

            //explicit loading
            //context.Entry(data).Collection(c=>c.courses).Load();

            //Anothreway for explicit loading
            //context.Courses.Where(c=>c.courses==data.id).Load();

            foreach (var det in data.courses)
            {
                Console.WriteLine(det.course2);
            }
            Console.ReadLine();

        }
    }
}
