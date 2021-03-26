using System;
using System.Globalization;

namespace Umar
{
    public class ReturnSortedFilteredArrays
    {
        public static void SortedFilteredArrays()
        {
            string[] names = { "ade", "bola", "lola", "bayo", "bimpe", "adeola", "dayo", "bimbo", "ololade", "bode" };

            Array.Sort(names);

            foreach (var item in names)
            {
                if (item.StartsWith("b"))
                {

                    var firstCharacter = item[0].ToString().ToUpper();

                    var otherCharacters = item.Substring(1);

                    Console.WriteLine($"{firstCharacter}{otherCharacters}");
                }
            }
        }

        public static void CapitalizeFirstLetterOfEachWord001(string argsSentence)
        {

            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(argsSentence.ToLower());

            Console.WriteLine(titleCase);

        }

        public static void CapitalizeFirstLetterOfEachWord002(string argsSentence)
        {
            //In Case if the entire string is in UpperCase then convert it into lower
            argsSentence = argsSentence.ToLower();

            char[] characterArray = argsSentence.ToCharArray();

            // Handle the first letter in the string.
            if (characterArray.Length >= 1)
            {
                if (char.IsLower(characterArray[0]))
                {
                    characterArray[0] = char.ToUpper(characterArray[0]);
                }
            }

            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < characterArray.Length; i++)
            {
                if (characterArray[i - 1] == ' ')
                {
                    if (char.IsLower(characterArray[i]))
                    {
                        characterArray[i] = char.ToUpper(characterArray[i]);
                    }
                }
            }
            Console.WriteLine(new string(characterArray));
        }
    }
}