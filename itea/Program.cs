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
            string fullName2 = Console.ReadLine();
            int firstSpace2 = fullName2.IndexOf(" ");
            int lastSpace2 = fullName2.LastIndexOf(" ");
            string surname2 = fullName2.Substring(0, firstSpace);
            string partName = fullName2.Substring(firstSpace + 1);
            string name2 = partName.Substring(0, firstSpace);
            string patronymic2 = fullName2.Substring(lastSpace + 1);
            string[,] full = {{surname2, name2, patronymic2},
                       {surname2, name2, patronymic2},  
                       {surname2, name2, patronymic2},};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(full[i, j]);
                }
                Console.WriteLine();
            }

            /*end second task*/

        }
    }
}

