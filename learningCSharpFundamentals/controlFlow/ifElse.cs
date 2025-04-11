using System.Reflection.Metadata;

namespace learningCSharpFundamentals.conditional
{
    class Conditonal
    {
        public static void Permitted(int age)
        {
            Console.WriteLine("---------Control Flow---------");

            bool answer = age >= 18;

            if (answer){
            Console.WriteLine("Access Granted!");
            }
            else{
                Console.WriteLine("Access Denied!");
            }
        }   
    }
}
