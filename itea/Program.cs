using System;

namespace itea
{
    class Program
    {
        static void Main(string[] args)
        {
            /*first task*/
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();
            int firstSpace = fullName.IndexOf(" ");
            int lastSpace = fullName.LastIndexOf(" ");
            string surname = fullName.Substring(0, firstSpace);
            surname = char.ToUpper(surname[0]) + surname.Substring(1);
            string name = fullName.Substring(firstSpace + 1, 1).ToUpper();
            string patronymic = fullName.Substring(lastSpace + 1, 1).ToUpper();
            Console.WriteLine($"Your short name is {surname } {name} {patronymic}");
            /*end first task*/
        }
    }
}

