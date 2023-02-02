using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Age age = new Age();
            int ageObj = 100;

            age.age(out ageObj);

            Console.WriteLine($"After Modification {ageObj}");
        }
    }
    class Age
    {
       public void age(out int notAge)
        {
            notAge = 0;
            notAge += 10;
            
        }
    }
}