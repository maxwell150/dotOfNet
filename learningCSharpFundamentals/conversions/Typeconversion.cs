using System;

namespace learningCSharpFundamentals.conversions
{
    class Typeconversion
    {
        public static void Demo()
        {

            byte num = 20;
            int intNum = num;
            // casting
            byte b = (byte)intNum;
            // using Convert
            byte b2 = Convert.ToByte(intNum);

            Console.WriteLine("This is an implicit type conversion (byte->int): {0}", intNum);
            Console.WriteLine("This is an explicit type conversion (int->byte): {0}", b);
            Console.WriteLine("This is an explicit type conversion (int->byte) using Convert: {0}", b2);

            try
                {
                    // string to int
                    string str = "123";
                    int numString = int.Parse(str);
                    Console.WriteLine("This is a string to int conversion: {0}", numString);
                }
            catch (Exception e)
                {
                    Console.WriteLine("Exception: {0}", e.Message);
                }
        }

    }
}
