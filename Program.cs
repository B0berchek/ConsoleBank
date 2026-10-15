using System;

namespace ConsoleBank
{
    internal class Program
    {
        const double BANKTHREEMONTH = 11.50; // 3 месяца
        const double BANKSIXMONTH = 11.75; // 6 месяцев
        const double BANKYEAR = 12.50; // год

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

            rep: Console.CursorLeft = 10;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите срок вклада -> ");
            Temp = Console.ReadLine();
            Period = Convert.ToInt32(Temp);

            if (Period != 91 && Period!=181 && Period != 365)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ошиблись со сроком. Повторите ещё раз");
                goto rep;
            }

            switch (Period)
            {
                case 91: PercentBank = BANKTHREEMONTH; break;
                case 181: PercentBank = BANKTHREEMONTH; break;
                case 365: PercentBank = BANKTHREEMONTH; break;
            }

            // Блок формирования сл. числа
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
