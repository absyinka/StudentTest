using System;
using Humanizer;

namespace Umar
{
    public class Dice
    {
        public static void DiceRoll()
        {
            Random random = new Random();

            int numberOfPlay = 7;

            int playCounts = 0;

            bool flag = true;

            while (flag && !(numberOfPlay < 1))
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int dice3 = random.Next(1, 7);

                int totalRoll = dice1 + dice2 + dice3;

                Console.WriteLine($"{dice1} + {dice2} + {dice3} = {totalRoll}");

                if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3)
                {
                    if ((dice1 == dice2) && (dice2 == dice3))
                    {
                        Console.WriteLine(StringConstants.triplePointMessage);
                        totalRoll += 6;
                    }
                    else
                    {
                        Console.WriteLine(StringConstants.doublePointMessage);
                        totalRoll += 2;
                    }
                }

                string finalMessage = (totalRoll >= 15) ? StringConstants.winMessage : StringConstants.loseMessage;

                Console.WriteLine(WithHumanizer(StringConstants.scoreMessage, new string[] { "point" }, totalRoll, finalMessage));

                if (numberOfPlay > 1)
                {
                    Console.WriteLine($"You have played {"times".ToQuantity(++playCounts)}, you have {"more times".ToQuantity(--numberOfPlay)} to play.");

                    string continueOption = string.Empty;

                    do
                    {
                        Console.Write(StringConstants.decisionMessage);

                        continueOption = Console.ReadLine();

                    } while (!continueOption.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueOption.Equals("N", StringComparison.OrdinalIgnoreCase));

                    flag = continueOption.Equals("Y", StringComparison.OrdinalIgnoreCase);

                    if (!flag)
                    {
                        Console.WriteLine($"You ended the game after {"play".ToQuantity(playCounts)}");
                    }
                }
                else
                {
                    Console.WriteLine(StringConstants.gameOverMessage);
                    flag = false;
                }

            }

        }

        public static string WithHumanizer(string majorStringPart1, string[] quantifiers, int quantity, string majorStringPart2 = "")
        {
            string newString = string.Empty;

            if (majorStringPart2 == "")
            {
                if (quantifiers.Length > 1)
                {
                    newString = $"{majorStringPart1} {quantifiers[0].ToQuantity(quantity)}";
                }
                else
                {
                    foreach (var quantifier in quantifiers)
                    {
                        newString = $"{majorStringPart1} {quantifier.ToQuantity(quantity)}";
                    }
                }
            }
            else
            {
                foreach (var quantifier in quantifiers)
                {
                    newString = $"{majorStringPart1} {quantifier.ToQuantity(quantity)} {majorStringPart2}";
                }

            }

            return newString;
        }
    }
}