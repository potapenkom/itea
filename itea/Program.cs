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
            int correctAnswer = random.Next(0, 100);
            int attempt = 1;
            string answerMore = "Enter number greater than";
            string answerSmall = "Enter a number less";
            do
            {
                Console.WriteLine("Enter a number from 1 to 100: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"userAnswer is {userAnswer}");
                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine($"Congratulations!!! You guessed the number on the {attempt} try");
                    break;
                }
                string hint = (userAnswer > correctAnswer) ? answerSmall : answerMore;
                Console.WriteLine(hint);
                if (attempt == 5)
                {
                    Console.WriteLine($"Attempts have ended. Game over. Correct answer was {correctAnswer}");
                }
                attempt += 1;
            } while (attempt <= 5);
            /*End second task*/
        }
    }
}
