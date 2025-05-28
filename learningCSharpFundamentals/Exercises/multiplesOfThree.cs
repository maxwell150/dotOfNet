namespace learningCSharpFundamentals.exercises
{
    public class Multiples
    {
        public static void Demo()
        {
            var count = 0;
            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            int count2 = (1000 - 1) / 3 + 1;
            Console.WriteLine(count2);
        }
        

    }
}