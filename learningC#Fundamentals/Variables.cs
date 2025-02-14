using System;

namespace Variables
{
    class Variables
    {
        public static void Demo()
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = true;

            Console.WriteLine("This is a byte variable: {0}", number);
            Console.WriteLine("This is an int variable: {0}", count);
            Console.WriteLine("This is a float variable: {0}", totalPrice);
            Console.WriteLine("This is a char variable: {0}", character);
            Console.WriteLine("This is a string variable: {0}", firstName);
            Console.WriteLine("This is a boolean variable: {0}", isWorking);
        }
    }
}
