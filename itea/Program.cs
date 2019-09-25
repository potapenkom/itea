using System;

namespace itea
{
    class Program
    {
        static void Main(string[] args)
        {
            /*first task v1*/
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
            /* end first task v1*/
            /*first task v2*/
            int[] num2 = { 1, 2, 3, 4, 5 };
            int[] num1 = { 11, 22, 33, 44, 55, 7, 8, 9, 10, 11, 14, 17 };
            int middle = (num1.Length < num2.Length) ? num2.Length / 2 : num1.Length / 2;
            if (num1.Length < num2.Length)
            {
                for (int j = 0; j < num1.Length; j++)
                {
                    num2[middle++] = num1[j];
                }
                Console.WriteLine();
                for (int j = 0; j < num2.Length; j++)
                {
                    Console.Write(num2[j] + ", ");
                }
            }
            else
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    num1[middle++] = num2[j];
                }
                Console.WriteLine();
                for (int j = 0; j < num1.Length; j++)
                {
                    Console.Write(num1[j] + ", ");
                }
            }
            /* end first task v2*/

            Console.WriteLine();
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

