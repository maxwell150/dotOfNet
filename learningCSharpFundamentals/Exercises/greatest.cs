using System;
using System.Globalization;

namespace learningCSharpFundamentals.exercises
{
    public class Exercises
    {
        public static void Greatest()
        {
            Console.Write("Enter first number: ");
            string? input1 = Console.ReadLine();

            Console.Write("Enter the second: ");
            string? input2 = Console.ReadLine();

            // Try parsing to integers
            if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {
                if (number1 > number2)
                {
                    Console.WriteLine("{0} is greater than {1}", number1, number2);
                }
                else if (number1 < number2)
                {
                    Console.WriteLine("{0} is greater than {1}", number2, number1);
                }
                else
                {
                    Console.WriteLine("Both numbers are equal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }
        public static void Validity()
        {
            Console.Write("Enter the number: ");
            string? userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int num))
            {
                if (num > 1 && num < 10)
                {
                    Console.WriteLine("Valid Number!");
                }
                else{
                    Console.WriteLine("Invalid Number!");
                }
            }
            else
            {
                Console.WriteLine("Enter a Valid Input!");
            }
        }

        public static void PortraitOrLandscape()
        {
            Console.Write("Enter the width: ");
            string? userInput1 = Console.ReadLine();
            Console.Write("Enter the Height: ");
            string? userInput2 = Console.ReadLine();

            if(int.TryParse(userInput1, out int width) && int.TryParse(userInput2, out int height))
            {
                if (height > width)
                {
                    Console.WriteLine("The Image is in Portrait Orientation!");
                }
                else
                    Console.WriteLine("The Image is in Landscape Orientation!");
            }
        }
public static void SpeedStatus()
{
    Console.Write("Enter the speed Limit: ");
    string? userInput1 = Console.ReadLine();
    Console.Write("Enter the speed of the car: ");
    string? userInput2 = Console.ReadLine();

    if (int.TryParse(userInput1, out int speedLimit) && int.TryParse(userInput2, out int carSpeed))
    {
        if (carSpeed > speedLimit)
        {
            int diff = carSpeed - speedLimit;
            int demeritPoints = diff / 5;

            if (demeritPoints > 12)
                Console.WriteLine("License Suspended!");
            else
                Console.WriteLine($"Demerit points: {demeritPoints}");
        }
        else
        {
            Console.WriteLine("Ok");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter numeric values.");
    }
}


    }
}
