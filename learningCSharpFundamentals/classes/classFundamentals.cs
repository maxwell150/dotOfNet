namespace learningCSharpFundamentals.classes
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            System.Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
}