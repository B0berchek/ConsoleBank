using System;

namespace ConsoleBank
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            double Summa, PercentBank, BonusInDay, BonusInPeriod;
            int Period;
            string Temp;

            Console.Write("Введите сумму клада -> ");
            Temp = Console.ReadLine();
            Summa = Convert.ToDouble(Temp);

            Console.Write("Введите срок вклада -> ");
            Temp = Console.ReadLine();
            Period = Convert.ToInt32(Temp);

            PercentBank = 5.25 + rand.NextDouble() * 11.61;
            Console.WriteLine("Ваш назначенный банковский % = {0:F2}", PercentBank); 

            BonusInDay = PercentBank / (100 * 365) * Summa;
            Console.WriteLine("Ваш ежедненый доход = " + BonusInDay.ToString("F2"));
            BonusInPeriod = BonusInDay * Period;
            Console.WriteLine($"Ваш доход за период = {BonusInPeriod:F2}");

            Summa += BonusInPeriod;
            Console.WriteLine($"Ваша сумма на счету в конце периода = {Summa:F2}");
            
            Console.ReadKey();
        }
    }
}
