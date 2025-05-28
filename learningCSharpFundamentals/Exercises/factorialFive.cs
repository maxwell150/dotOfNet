namespace learningCSharpFundamentals.factorial
{
    class Factorial
    {
        public static void Demo()
        {
            var multiFactor = 1;
            Console.Write("Enter a number: ");
            var value = Console.ReadLine();
            if (int.TryParse(value, out int valueFactorial))
            {
                for (var i = 1; i <= valueFactorial; i++)
                {
                    multiFactor *= i;
                }
                Console.WriteLine("{0}! = {1}", value, multiFactor);
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}