using System;

namespace itea
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Задача №1. Вывести в консоль самое дорогое пиво, которое можнокупить за указаную сумму денег.*/
            int money = 7;
            string drink = "";
            int rest = 0;
            int leffe = 80;
            int hoegarden = 70;
            int stella = 60;
            int obolon = 7;
            if (money >= leffe)
            {
                rest = money - leffe;
                drink = "Leffe";
            }
            else if (money >= hoegarden)
            {
                rest = money - hoegarden;
                drink = "Hoegarden";
            }
            else if (money >= stella)
            {
                rest = money - stella;
                drink = "Stella Artois";
            }
            else if (money >= obolon)
            {
                rest = money - obolon;
                drink = "Obolon";
            }
            else
            {
              Console.WriteLine($"У Вас: {money} грн. Не достаточно для покупки пива!!!");
            }
              Console.WriteLine($"У Вас: {money} грн. Сомое дорогое пиво, которое вы можете купить- {drink}. Остаток денег {rest} грн");
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
