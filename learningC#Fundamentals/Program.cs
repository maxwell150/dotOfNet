using System;
using Variables;
using Typeconversion;
using classFundamentals;



class Program
{
    public static void Main()
    {
        Console.WriteLine("----------Variables------------");
        Variables.Variables.Demo();

        Console.WriteLine("---------------Type conversion-----------------");
        Typeconversion.Typeconversion.Demo();
        
        Console.WriteLine("---------------Classes-----------------");
        Person maxwell = new Person();
        maxwell.Introduce();

    }
}
