namespace learningCSharpFundamentals.csv
{
    class Csv
    {
        public static void Demo()
        {
            Console.Write("Enter comma separates integers: ");
            var input = Console.ReadLine();
            int largestNumber = int.MinValue;
            if (input != null)
            {
                var parts = input.Split(',');
                foreach (var part in parts)
                {
                    if (int.TryParse(part, out int value))
                    {
                        if (value > largestNumber)
                        {
                            largestNumber = value;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine("The largets number is: {0}",largestNumber);
        }
    }
}