using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //Poistetaan syötteestä välimerkit
            origInput = origInput.Replace(" ", string.Empty);
            origInput = origInput.Replace(",", string.Empty);
            origInput = origInput.Replace(".", string.Empty);
            origInput = origInput.Replace("!", string.Empty);
            origInput = origInput.Replace("?", string.Empty);

            //Leikataan muokattu syöte puoliksi
            int halfLength = origInput.Length / 2;
            string firstHalf = origInput.Remove(halfLength);

            //Luodaan uusi merkkijono, muokattu syöte takoperin ja leikattu puoliksi
            char[] process = origInput.ToCharArray();
            Array.Reverse(process);
            string secondHalf = new string(process).Remove(halfLength);

            //Verrataan puolikkaita kekskenään, jos samat niin syöte oli palindromi
            //Tulostetaan vastaus
            Console.WriteLine($"Input: {input}");
            if (firstHalf == secondHalf)
            {
                Console.WriteLine($"Output: Your input ¨{input}¨ is a palindrome.");
            } else {
                Console.WriteLine($"Output: Your input ¨{input}¨ is not a palindrome");
            }
        }
    }
}
