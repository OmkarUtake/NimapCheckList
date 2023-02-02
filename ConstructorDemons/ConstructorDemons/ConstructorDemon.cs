using System;


namespace ConstructorDemons
{

    
     //Default Constructor without declaring it work same as parameterless
     //constructore use to initialize default values of variables

     class DefConst
     {
         int age;
         String Name;

         public static void Main(String[] args)
         {
             DefConst obj = new DefConst();
             obj.age = 20;
             Console.WriteLine(obj.age + " " + obj.Name);
         }

     }
    


    /*
    //Parameterized constructor used to initialize user defined values instead of default values. 
    class ParalessConst
    {
        public int age;
        public String Name;

        public ParalessConst(int age,String Name)
        {
            this.age = age;
            this.Name = Name;
        }
        public static void Main(String[] args)
        {
            ParalessConst obj = new ParalessConst(25, "Omkar");
            Console.WriteLine(obj.age+"\n"+obj.Name);
        }
    }
    */

    /*
    //Copy Construtor used to copy data of one object into another
    class copyConst
    {
        public int age;
        public String Name;

        public copyConst(int age,String Name)
        {
            this.age= age;
            this.Name= Name;
        }
        copyConst(copyConst cs)
        {
            this.age= cs.age;
            this.Name= cs.Name;
        }

        public static void Main(String[] args)
        {
            copyConst obj = new copyConst(20, "Omkar");

            copyConst obj1 = new copyConst(obj);

            Console.WriteLine(obj1.age+"\n"+obj1.Name);
        }
    }

    /*
    //Private Constructor to restrict creating object of this class in another class

    class PrivtConst
    {
        

       private PrivtConst()
        {
            Console.WriteLine("Constructore called");

        }
    }

    class newClass
    {
        public static void Main(string[] args)
        {
            PrivtConst obj = new PrivtConst();
        }
    }
    */

    /*
    //static Constructor executes only once while another construtors always called when object creates

    class StaticConst
    {
        public StaticConst()
        {
            Console.WriteLine("Non-Static Constructor");
        }
        static StaticConst()
        {
            Console.WriteLine("Static Const");
        }

        public static void Main(string[] args)
        {
            StaticConst obj = new StaticConst();
            StaticConst obj2 = new StaticConst();
        }

        
    }
    */


    /*
    //Constructor Overloading
    class ConstOverload
    {
        int age;
        public ConstOverload()
        {
            Console.WriteLine("Constructor without Parameters");
        }

        public ConstOverload(String str)
        {
            Console.WriteLine("If we pass any parameter constructor will be overloaded");
        }

        public static void Main(String[] args)
        {
            ConstOverload obj= new ConstOverload();
            ConstOverload obj1 = new ConstOverload("Name");

        }
    */
    }
}
