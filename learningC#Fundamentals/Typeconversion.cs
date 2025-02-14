using System;

namespace Typeconversion
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
        }
    }
}
