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
            double summa, percentBank, bonusMonth, bonusInPeriod;
            int period, countMonth;
            string temp;

            Console.Title = "Банковская задача";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            // Блок ввода данных
            Console.SetCursorPosition(10, 10);
            Console.Write("Введите сумму клада -> ");
            temp = Console.ReadLine();
            summa = Convert.ToDouble(temp);

            rep: Console.CursorLeft = 10;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите срок вклада -> ");
            temp = Console.ReadLine();
            period = Convert.ToInt32(temp);

            if (period != 91 && period!=181 && period != 365)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ошиблись со сроком. Повторите ещё раз");
                goto rep;
            }

            percentBank = 0;
            switch (period)
            {
                case 91: percentBank = BANKTHREEMONTH; break;
                case 181: percentBank = BANKTHREEMONTH; break;
                case 365: percentBank = BANKTHREEMONTH; break;
            }

            // Блок формирования сл. числа
            Console.CursorLeft = 10;
            Console.WriteLine("Ваш назначенный банковский % = {0:N2}", percentBank);

            // Расчётный блок
            countMonth = period / 30;        // Кол-во месяец строока
            bonusInPeriod = 0;               // ОБщий доход за весь период
            for (int month = 1; month <= countMonth; month++)
            {
                bonusMonth = percentBank / 100/ 12 * summa;
                summa = summa + bonusMonth;
                bonusInPeriod += bonusMonth;
                Console.CursorLeft = 10;
                Console.WriteLine($"Ваш ежемесячный доход в {month} месяц " + bonusMonth.ToString("N2") + " в рублях");
                Console.CursorLeft = 10;
                Console.WriteLine($"Ваша сумма на счету в {month} месяц " + summa.ToString("N2") + " в рублях");
            }

            // Результат
            summa += bonusInPeriod;
            Console.CursorLeft = 10;
            Console.WriteLine($"Ваша общая банковская надбавка а весь период = {bonusInPeriod:N2} в рублях");
            Console.CursorLeft = 10;
            Console.WriteLine($"Ваша сумма на счету в конце периода = {summa:N2} в рублях");

            Console.ReadKey();
        }
    }
}
