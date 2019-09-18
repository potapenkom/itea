using System;

namespace itea
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Задача №1. Вывести в консоль самое дорогое пиво, которое можнокупить за указаную сумму денег.*/
            int money = 13;
            int leffe = 80;
            int hoegarden = 70;
            int stella = 60;
            int obolon = 7;
            if (money >= leffe)
            {
                int rest = money - leffe;
                Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- Leffe. Остаток денег {rest} грн");
            }
            else if (money >= hoegarden)
            {
                int rest = money - hoegarden;
                Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- Hoegarden. Остаток денег {rest} грн");
            }
            else if (money >= stella)
            {
                int rest = money - stella;
                Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- Stella Artois. Остаток денег {rest} грн");
            }
            else if (money >= obolon)
            {
                int rest = money - obolon;
                Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- Obolon. Остаток денег {rest} грн");
            }
            else
            {
                Console.WriteLine($"У Вас: {money} грн. Не достаточно для покупки пива!!!");
            }
            /*Конец задачи №1*/
            /*Задача №2. вывести в консоль сумму покупки со скидкой*/
            double sum = 300;
            double procent;
            if (sum > 500)
            {
                procent = 5;
                sum -= sum * (procent / 100);
            }
            else if (sum > 400 && sum <= 500)
            {
                procent = 3;
                sum -= sum * (procent / 100);
            }
            else if (sum > 300 && sum <= 400)
            {
                procent = 2;
                sum -= sum * (procent / 100);
            }
            else
            {
                procent = 0;
                sum -= procent;
            }
            Console.WriteLine($"Ваша скидка {procent}%. Суммa покупки после скидки: {sum} грн");
            /*Конец задачи №2*/
            Console.ReadKey();
        }
    }
}
