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
           /* end first task*/
            /*second task*/
            string[][] fullNameArr = new string[3][];
            for (int k = 0; k < fullNameArr.Length; k++)
            {
                Console.Write("Enter your full name: ");
                string fullName1 = Console.ReadLine();
                int firstSpace1 = fullName1.IndexOf(" ");
                int lastSpace1 = fullName1.LastIndexOf(" ");
                string surname1 = fullName1.Substring(0, firstSpace1);
                string partName = fullName1.Substring(firstSpace1 + 1);
                int firstSpace2 = partName.IndexOf(" ");
                string name1 = partName.Substring(0, firstSpace2);
                string patronymic1 = fullName1.Substring(lastSpace1 + 1);
                for (int i = 0; i < fullNameArr.Length; i++)
                {
                    fullNameArr[i] = new string[] { surname1, name1, patronymic1 };
                }
                }
                for (int i = 0; i < fullNameArr.Length; i++)
                {
                for (int j = 0; j < fullNameArr[i].Length; j++)
                {
                    Console.Write(fullNameArr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Enter a string to search for: ");
            string search = Console.ReadLine();
            for (int i = 0; i < fullNameArr.Length; i++)
            {
                for (int j = 0; j < fullNameArr[i].Length; j++)
                {
                    string str = fullNameArr[i][j];
                    if (str.IndexOf(search) != -1)
                    {
                        Console.WriteLine("Substring " + search + " found!");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
            }

            /*end second task*/

        }
    }
}

