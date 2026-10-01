using System;

namespace ConsoleBank
{
    internal class Program
    {
        static Random rand = new Random();
        // Точка входа в программу
        static void Main(string[] args)
        {
            // Блок объяления локлаьных величин
            double Summa, PercentBank, BonusInDay, BonusInPeriod;
            int Period;
            string Temp;

            Console.Title = "Банковская задача";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            // Блок ввода данных
            Console.SetCursorPosition(10, 10);
            Console.Write("Введите сумму клада -> ");
            Temp = Console.ReadLine();
            Summa = Convert.ToDouble(Temp);

            Console.CursorLeft = 10;
            Console.Write("Введите срок вклада -> ");
            Temp = Console.ReadLine();
            Period = Convert.ToInt32(Temp);

            // Блок формирования сл. числа
            PercentBank = 5.25 + rand.NextDouble() * 11.61;
            Console.CursorLeft = 10;
            Console.WriteLine("Ваш назначенный банковский % = {0:F2}", PercentBank); 

            BonusInDay = PercentBank / (100 * 365) * Summa;
            Console.CursorLeft = 10;
            Console.WriteLine("Ваш ежедненый доход = " + BonusInDay.ToString("F2"));
            BonusInPeriod = BonusInDay * Period;
            Console.CursorLeft = 10;
            Console.WriteLine($"Ваш доход за период = {BonusInPeriod:F2}");

            // Результат
            Summa += BonusInPeriod;
            Console.CursorLeft = 10;
            Console.WriteLine($"Ваша сумма на счету в конце периода = {Summa:F2}");
            
            Console.ReadKey();
        }
    }
}
