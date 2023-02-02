using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class LambdaExp
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 101, Name = "Emp1" },
                new Employee { Id = 102, Name = "emp2" },
                new Employee { Id = 103, Name = "emp3" },
                new Employee { Id = 104, Name = "emp5" },
                new Employee { Id = 105, Name = "emp9" },
                new Employee { Id = 106, Name = "emp6" },
                new Employee { Id = 107, Name = "emp4" },


            };
            int employeeId = 107;
            Employee emp = employees.Find(x => x.Id == employeeId);
            Console.WriteLine($"{emp.Name} is the employe having id {emp.Id}");


            Console.WriteLine("Ordered by name");
            var orderbyName = employees.OrderBy(x => x.Name);
            foreach (var det in orderbyName)
            {
                Console.WriteLine($"{det.Id} {det.Name}");
            }




        }
    }
}
