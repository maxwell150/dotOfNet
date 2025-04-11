using System;
using learningCSharpFundamentals.math;
using learningCSharpFundamentals.stringOps;
using learningCSharpFundamentals.Enums;
using learningCSharpFundamentals.conditional;
using learningCSharpFundamentals.exercises;

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
            var fname = "Maxwell";
            var lname =  "Muthengia";
            StringsFundamentals strOps = new();
            strOps.StringOperations(fname, lname);

            Console.WriteLine("-------Enum-------");
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //ifElse
            var age = 17;
            Conditonal.Permitted(age);
            //swith;
            Switching.IsItTime();
            
            Console.WriteLine("-----------Exercises-------------");
            Exercises.Greatest();
            Exercises.Validity();
            Exercises.PortraitOrLandscape();
            Exercises.SpeedStatus();

        }
    }
}