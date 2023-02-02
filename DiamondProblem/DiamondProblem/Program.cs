using System;


namespace DiamondProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Addition addition = new Addition();
            CAlculator calc = addition;
            calc.Add(10, 20);
            

            MObile mob = addition;
            mob.Add(10, 100);

            addition.method();

        }
    }

    interface CAlculator
    {
        int Add(int a, int b);
    }

    interface MObile
    {
        int Add(int a, int b);
    }

    class Addition : CAlculator, MObile
    {
        int CAlculator.Add(int a, int b)
        {
            Console.WriteLine("Calctulator returns addition from add method");
            return a + b;
        }

        int MObile.Add(int a, int b)
        {
            Console.WriteLine("MObile returns addition from add method");
            return a + b;
        }

       public void method()
        {
            Console.WriteLine("Addittion class Metod");
        }
    }
}
