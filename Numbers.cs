using System;

namespace Umar
{
    public class Numbers
    {
        public static void MoneyLoop()
        {
            for(double dollar = 1; dollar <= 10; dollar++)
            {
                const double naira = 482.543;

                double dollarToNaira = (dollar * naira);

                // dollarToNaira.ToString("n2");
                // dollarToNaira.ToString("c2");

                Console.WriteLine($"USD: {dollar}    NGN: {dollarToNaira.ToString("0.00")}");
            }
        }
    }
}