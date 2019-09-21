using System;

namespace itea
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Start first task*/
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
            /*End first task*/
            /*Start second task*/
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            Console.WriteLine($"Rand is {randomNumber}");
            int attempt = 1;
            do
            {
                Console.WriteLine("Enter number from 1 to 100: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == input)
                {
                    Console.WriteLine($"Congratulations!!! You guessed the number on the {attempt} try");
                    break;
                }
                else if (input > randomNumber)
                {
                    Console.WriteLine("Enter a number less");
                }
                else
                {
                    Console.WriteLine("Enter number greater than");
                }
                attempt += 1;
            } while (attempt <= 5);
            Console.WriteLine("Attempts have ended. Game over");
            /*End second task*/
        }
    }
}
