namespace learningCSharpFundamentals.stringOps
{
    public class StringsFundamentals
    {
        public void StringOperations(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            string fullName2 = string.Format(" My name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName2);

            string fullName3 = $"My name is {firstName} {lastName}";
            Console.WriteLine(fullName3);

            string[] names = new string[3] { "John", "Doe", "Smith" };
            Console.WriteLine(names[0] + " " + names[1] + " " + names[2]);

            string formattedNames = string.Join(" ", names);
            Console.WriteLine(formattedNames);

            string text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            string text2 = @"Hi John Look into the following paths c:\folder1\folder2 c:\folder3\folder4";
            Console.WriteLine(text2);
            
        }
    }

}