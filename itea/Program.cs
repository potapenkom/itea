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
        }
    }
}

