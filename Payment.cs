using System;

namespace Umar
{
    public class Payment
    {
        public static void WorkPay()
        {
            const double dollarPerHour = 25;

            int hoursWorked = 0;

            double payOutPerMonth = dollarPerHour * hoursWorked;

            double taxRate = 0;

            Console.WriteLine(payOutPerMonth);

            if (payOutPerMonth == 0)
            {
                Console.WriteLine("You dont have any payment for the month");
            }
            else if (payOutPerMonth < 1500)
            {
                taxRate += 0.02;

                double deduction = payOutPerMonth * taxRate;

                payOutPerMonth -= deduction;

                Console.WriteLine($"Deduction: {deduction}");

                Console.WriteLine(payOutPerMonth);
            }
            else if (payOutPerMonth == 1500)
            {
                taxRate += 0.05;

                double deduction = payOutPerMonth * taxRate;

                payOutPerMonth -= deduction;

                Console.WriteLine($"Deduction: {deduction}");

                Console.WriteLine(payOutPerMonth);
            }
            else if (payOutPerMonth >= 2250 && payOutPerMonth <= 2500)
            {
                taxRate += 0.10;

                double deduction = payOutPerMonth * taxRate;

                payOutPerMonth -= deduction;

                Console.WriteLine($"Deduction: {deduction}");

                Console.WriteLine(payOutPerMonth);
            }
            else
            {
                taxRate += 0.15;

                double deduction = payOutPerMonth * taxRate;

                payOutPerMonth -= deduction;

                Console.WriteLine($"Deduction: {deduction}");

                Console.WriteLine(payOutPerMonth);
            }
        }

    }
}