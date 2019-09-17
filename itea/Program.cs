using System;

namespace itea
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Задача №1. Вывести в консоль самое дорогое пиво, которое можнокупить за указаную сумму денег.*/
            int money = 4;
            if (money >= 60)
            {
                Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- Leffe");
            }
            else if (money >= 45)
            {
                Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- Bud");
            }
            else if (money >= 30)
            {
                Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- Stella Artois");
            }
            else if (money >= 20)
            {
                Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- Chernigivske");
            }
            else if (money >= 7)
            {
                Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- Obolon");
            }
            else
            {
                Console.WriteLine($"У Вас: {money} грн. Не достаточно для покупки пива!!!");
            }
            /*Конец задачи №1*/
            /*Задача №2. вывести в консоль сумму покупки со скидкой*/
            double sum = 610;
            double procent;
            if (sum > 500)
            {
                procent = 7;
                sum -= sum * 0.07;
            }
            else if (sum >= 400 && sum <= 500)
            {
                procent = 5;
                sum -= sum * 0.05;
            }
            else if (sum >= 300 && sum <= 400)
            {
                procent = 5;
                sum -= sum * 0.03;
            }
            else
            {
                procent = 0;
                sum -= procent;
            }
            Console.WriteLine($"Ваша скидка {procent}%. Суммa покупки после скидк: {sum}");
            /*Конец задачи №2*/
            Console.ReadKey();
        }
    }
}
