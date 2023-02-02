using System;

namespace KeywordDemon
{
    class ReadOnlyKey
    {
        readonly int index = 10;
        readonly int length;
        readonly int width;
       
        public ReadOnlyKey(int length)
        {
            this.length = length;
        }

        public static void Main(string[] args)
        {
            
            ReadOnlyKey key = new ReadOnlyKey(10);
            //key.width = 10;    not valid because readonly keyword
            Console.WriteLine(key.index);
            Console.WriteLine(key.width);

        }
    }
}
