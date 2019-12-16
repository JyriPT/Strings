﻿using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 / 2);
            //Kaikki tehtävät tehty yhteen, tehtävien tarkistus tehdään valikon kautta
            int select;
            string input;
            string phrase;
            Console.WriteLine("Select the assignment you wish to check (number 1-4):");
            Console.WriteLine("");

            //Laitetaan käyttäjän valinta string arvoon
            input = Console.ReadLine();
            Console.WriteLine("");

            //Pyydetään käyttäjältä merkkijono käsiteltäväksi
            Console.WriteLine("Please input phrase to be processed:");
            Console.WriteLine();
            phrase = Console.ReadLine().Trim();

            //Käsitellään edellä annettu arvo.
            //Jos mahdollista muuttaa int arvoksi, tarkistetaan mikä numero.
            //Jos annettu arvo ei ole numero väliltä 1-4, mitään ei tapahdu.
            if (int.TryParse(input, out select) == true)
            {
                if (select == 1)
                {
                    checkLength(phrase);
                }
                else if (select == 2)
                {
                    changeE(phrase);
                }
                else if (select == 3)
                {
                    countingL(phrase);
                }
                else if (select == 4)
                {
                    isPalindrome(phrase);
                }
                else
                {
                    Console.WriteLine("Invalid selection, please reboot.");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection, please reboot.");
            }
        }

        //Merkkijonon pituuden tarkistus
        static void checkLength(string input)
        {
            int length = input.Length;

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: String contains {length} characters.");
        }

        //E kirjainten muuttaminen
        static void changeE(string input)
        {
            string output;

            //Käytetään replace-toimintoa kahteen kertaan, jotta saadaan muutettua sekä isot että pienet E kirjaimet
            output = input.Replace("e", "@").Replace("E", "@");

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {output}");
        }

        //L kirjainten laskenta
        static void countingL(string input)
        {
            int count = 0;

            foreach (char i in input)
            {
                if (i.ToString() == "l" || i.ToString() == "L")
                {
                    count++;
                }
            }

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: String '{input}' contains {count} instances of the letter L.");
        }

        //Palindromi tarkistus
        static void isPalindrome(string input)
        {
            string origInput = input.ToLower();
            int count = 0;

            Console.WriteLine(origInput);

            //Poistetaan syötteestä välimerkit
            foreach (char i in origInput)
            {
                if (i.ToString() == " " || i.ToString() == "," || i.ToString() == ".")
                {
                    origInput.Remove(count, 1);
                    count--;
                }

                count++;
            }

            //Luodaan uusi merkkijono, syöte takoperin
            char[] process = origInput.ToCharArray();
            Array.Reverse(process);
            string backwards = new string(process);

            //HOW DO I MAKE THIS BIT WORK?
            #region
            //Verrataan merkkijonoja keskenään
            int length = origInput.Length;
            int countReverse = length;
            int countTrue = 0;

            for (int countMain = 0; countMain < length; countMain++)
            {
                //
                //ALERT
                //HOW THE FUCK EVEN
                //
                if (1 == 1)
                {
                    countTrue++;
                }

                countReverse--;
            }
            #endregion

            //Tulostetaan, onko lause palindromi vai ei
            Console.WriteLine($"Input: {input}");
            if (countTrue == length)
            {
                Console.WriteLine($"Output: Your input ¨{input}¨ is a palindrome.");
            }

            Console.WriteLine($"Output: Your input ¨{input}¨ is not a palindrome");
        }
    }
}
