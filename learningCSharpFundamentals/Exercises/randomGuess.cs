
namespace learningCSharpFundamentals.random
{
    class RandomGuess
    {
        public static void Demo()
        {
            Random random = new();
            int secretNumber = random.Next(1, 10);
            Console.WriteLine(secretNumber);
            Console.WriteLine("Gues a number between 1 and 10.\nYou win if you guess the secret number");
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Enter the number: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int userInput))
                {
                    if (int.Equals(userInput, secretNumber))
                    {
                        Console.WriteLine("You won!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Nop, Try Again!");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid number");
                }

            }
            Console.WriteLine("You lost! The secret number was {0}", secretNumber);

        }
    }
}