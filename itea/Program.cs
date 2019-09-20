using System;

namespace itea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int length = 0;
            int sum = 0;
            int count = 0;
            do
            {
                length += 1;
                int digit = number % 10;
                if (digit % 2 == 0)
                    sum += digit;

                if (digit % 3 == 0)
                    count += 1;
                number /= 10;

            } while (number > 0);

            Console.WriteLine($"Digits in number: {length}, Sum of even numbers: {sum}, Number of multiples of three: {count}.");
        }
    }
}
