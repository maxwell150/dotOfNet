namespace learningCSharpFundamentals.math
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            int[] result = new int[3];
            int count = 11;
            for (int i = 0; i <= 2; i++)
            {
                result[i] = count;
                count += 5;
                Console.WriteLine("Result: {0}", result[i]);
            }
            return result[2]+a+b;
            
        }
    }
}