using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public interface Food
    {
        public float getTotalCalories();
        public String getOrigin();
    }

    public abstract class Fruit : Food
    {
        public float getTotalCalories()
        {
            return 0.50f;
        }
        public abstract String getOrigin();
    }
}