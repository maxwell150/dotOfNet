using System;
using learningCSharpFundamentals.math;
using learningCSharpFundamentals.stringOps;

namespace learningCSharpFundamentals

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Calculator---------");
            Calculator calc = new();
            int result = calc.Add(10, 20);
            Console.WriteLine("Addition: {0}", result);


            Console.WriteLine("------Strings---------");
            StringsFundamentals strOps = new();
            strOps.StringOperations();
        

        }
    }
}