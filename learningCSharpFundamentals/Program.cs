using learningCSharpFundamentals.csv;

namespace learningCSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to count how many numbers between 1 and 100 
            //are divisible by 3 with no remainder. Display the count on the console.
            //Multiples.Demo();

            //Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console.
            //PromptUser.Demo();

            //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            //Factorial.Demo();

            // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            // If the user guesses the number, display “You won"; otherwise, display “You lost". 
            // (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            //RandomGuess.Demo();

            //Write a program and ask the user to enter a series of numbers separated by comma. 
            //Find the maximum of the numbers and display it on the console. 
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            Csv.Demo();




        }

    }
}
