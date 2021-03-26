using System;

namespace Umar
{
    public class Dice
    {
        public static void DiceRoll()
        {
            Random random = new Random();

            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);

            int totalRoll = dice1 + dice2 + dice3;

            Console.WriteLine($"{dice1} + {dice2} + {dice3} = {totalRoll}");

            if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3) 
            {
                if ((dice1 == dice2) && (dice2 == dice3))
                {
                    Console.WriteLine("You scored +6 bonus point for rolling a triple!");
                    totalRoll += 6;
                }
                else
                {
                    Console.WriteLine("You scored +2 bonus point for rolling a double!");
                    totalRoll += 2;
                }
            }

            Console.WriteLine($"You scored: {totalRoll}");

            string finalMessage = (totalRoll >= 15) ? "You won!" : "You lose";

            Console.WriteLine(finalMessage);
        }
    }
}