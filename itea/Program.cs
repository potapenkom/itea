using System;

namespace itea
{
    class Program
    {
        static void Main(string[] args)
        {
            /*first task*/
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[10];
            if (arr1.Length < arr2.Length)
            {
                Array.Copy(arr1, 0, arr2, arr2.Length / 2, arr1.Length);
            }
            else
            {
                Array.Copy(arr1, 0, arr2, arr2.Length / 2, arr1.Length);
            }

            for (int i = 0; i < arr2.Length; i += 1)
            {
                Console.Write($"{arr2[i]}");
            }
            /* end first task*/
            Console.WriteLine("Second task");
            /*Second task*/
            int month = 12;
            int days31 = 31;
            int days30 = 30;
            int days28 = 28;

            for (int i = 1; i <= month; i++)
            {
                Console.WriteLine("Месяц " + i);
                if (i == 2)
                {
                    for (int x = 1; x <= days28; x++)
                    {
                        Console.WriteLine("День " + x);
                    }
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    for (int x = 1; x <= days30; x++)
                    {
                        Console.WriteLine("День " + x);
                    }
                }
                else
                {
                    for (int x = 1; x <= days31; x++)
                    {
                        Console.WriteLine("День " + x);
                    }
                }
                Console.WriteLine();
            }
            /* end second task*/
        }
    }
}

