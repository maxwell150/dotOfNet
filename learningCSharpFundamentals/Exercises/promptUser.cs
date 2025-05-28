namespace learningCSharpFundamentals.promptUser
{
    public class PromptUser
    {
        public static void Demo()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number or ok to exit: ");
                string? input = Console.ReadLine();

                if (string.Equals(input, "ok", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (int.TryParse(input, out int num))
                {
                    sum += num;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}