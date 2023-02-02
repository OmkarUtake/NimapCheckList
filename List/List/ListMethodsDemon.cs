using System;
using System.Collections.Generic;
using System.Collections;


namespace Lists
{
    public class Student
    {
        public int id;
        public string name;
        public List<string> email = new List<string>();

        public void Display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            foreach(var details in email)
            {
                Console.WriteLine(details);
            }
            
        }
    }
    class ListMethodsDemon
    {
        public static void Main(string[] args)
        {
            Student student = new Student();

            student.email.Add("Omkar@gmail.com");
            student.email.Add("Omkar@yahoo.com");
            student.name = "Omkar";
            student.id = 1;

           student.Display();
            




        }
    }



    /*
    class ListMethodsDemon
    {
        public static void Main(String[] args)
        {
            var list = new List<int>();


            void display()
            {
                foreach (var i in list)
                {
                    Console.Write(i+" ");
                    
                }
                Console.WriteLine();
            }

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            display();
            list.Insert(1, 100);
            display();
            list.Remove(100);
            display();
            list.RemoveAt(3);
            display();

        }


    }
    */
}
