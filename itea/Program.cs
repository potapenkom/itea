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
            /*second task*/
            Console.Write("Enter your full name: ");
            string fullName1 = Console.ReadLine();
            int firstSpace1 = fullName1.IndexOf(" ");
            int lastSpace1 = fullName1.LastIndexOf(" ");
            string surname1 = fullName.Substring(0, firstSpace1);
            string partName = fullName.Substring(firstSpace1 + 1);
            int firstSpace2 = partName.IndexOf(" ");
            string name1 = partName.Substring(0, firstSpace2);
            string patronymic1 = fullName.Substring(lastSpace1 + 1);

            char[] surnameArr = surname1.ToCharArray();
            char[] nameArr = name1.ToCharArray();
            char[] patronymicArr = patronymic1.ToCharArray();
            char[][] fullNameArr = new char[3][];

            fullNameArr[0] = new char[surnameArr.Length];
            fullNameArr[1] = new char[nameArr.Length];
            fullNameArr[2] = new char[patronymicArr.Length];

            int i;
            for (i = 0; i < surnameArr.Length; i++)
                fullNameArr[0][i] = surnameArr[i];
            for (i = 0; i < nameArr.Length; i++)
                fullNameArr[1][i] = nameArr[i];
            for (i = 0; i < patronymicArr.Length; i++)
                fullNameArr[2][i] = patronymicArr[i];

            for (i = 0; i < surnameArr.Length; i++)
                Console.Write(fullNameArr[0][i] + " ");
                Console.WriteLine();

            for (i = 0; i < nameArr.Length; i++)
                Console.Write(fullNameArr[1][i] + " ");
                Console.WriteLine();

            for (i = 0; i < patronymicArr.Length; i++)
                Console.Write(fullNameArr[2][i] + " ");
                Console.WriteLine();

            Console.Write("Enter a string to search for: ");
            string search = Console.ReadLine();
            if (fullName1.StartsWith(search) == true)
            {
                Console.WriteLine("Substring found!");
            }
                Console.WriteLine("Substring not found!");

            /*end second task*/

        }
    }
}

