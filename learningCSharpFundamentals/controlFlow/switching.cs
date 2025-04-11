using learningCSharpFundamentals.Enums;

namespace learningCSharpFundamentals.conditional
{
    class Switching{
        public static void IsItTime()
        {
            Console.WriteLine("------Switching---------");
            var day = DaysOfTheWeek.Monday;

            switch(day)
            {
                case DaysOfTheWeek.Monday://Monday
                    Console.WriteLine("You have to go to the Gym!");
                    break;

                case DaysOfTheWeek.Tuesday:
                    Console.WriteLine("You are to go to the Market");
                    break;

                case DaysOfTheWeek.Wednesday:
                    Console.WriteLine("Its Service Day!");
                    break;

                case DaysOfTheWeek.Thursday:
                    Console.WriteLine("Hello, Today you tribe mindset Education!");
                    break;

                case DaysOfTheWeek.Friday:
                    Console.WriteLine("Hello, Take a rest");
                    break;

                default:
                    Console.WriteLine("That day seems anywhoooo!");
                    break;
            }
        }
    }

}