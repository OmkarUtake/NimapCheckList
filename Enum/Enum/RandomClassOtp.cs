


namespace Enum
{
    class RandomClassOtp
    {
        Random rd = new Random();
        int otp;
        public int generate()
        {
            otp = rd.Next(10000000, 99999999);
            return otp;
        }

        public bool validte(int i)
        {
            if (i == otp)
            {
                return true;
            }
            else return false;



        }


        static void Main(string[] args)
        {

            RandomClassOtp obj = new RandomClassOtp();
            int otpprint = obj.generate();
            Console.WriteLine($"Your Otp is : {otpprint}");



            Console.WriteLine("\nEnter OPT");
            var input = Convert.ToInt32(Console.ReadLine());

            if (obj.validte(input))
            {
                Console.WriteLine("Otp matched");
            }
            else
            {
                Console.WriteLine("Enter correct otp");
            }



        }
    }
}
