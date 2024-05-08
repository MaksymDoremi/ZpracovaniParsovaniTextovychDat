using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ZpracovaniParsovaniTextovychDat
{
    public class Prorgam
    {
        public static void Main(string[] args)
        {
            // Deklarace a inicializace stringu
            string prvniString = "Hello";
            string druhyString = "World";

            // Konkatenace stringů
            string spojenyString = prvniString + " " + druhyString;
            Console.WriteLine("Spojený string: " + spojenyString);

            // Délka stringu
            int delkaStringu = spojenyString.Length;
            Console.WriteLine("Délka spojeného stringu: " + delkaStringu);

            // Porovnání stringů
            bool jsouStejne = prvniString.Equals(druhyString, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Jsou stejné: " + jsouStejne);

            // Převod na velká písmena
            string velkaPismena = prvniString.ToUpper();
            Console.WriteLine("Velká písmena: " + velkaPismena);

            // Převod na malá písmena
            string malaPismena = druhyString.ToLower();
            Console.WriteLine("Malá písmena: " + malaPismena);

            // Získání podřetězce
            string podretezec = spojenyString.Substring(0, 5);
            Console.WriteLine("Podřetězec: " + podretezec);

            // Rozdělení stringu
            string[] rozdelenyString = spojenyString.Split(' ');
            Console.WriteLine("Rozdělený string:");
            foreach (string cast in rozdelenyString)
            {
                Console.WriteLine(cast);
            }

            // Nahrazení části stringu
            string nahrazenyString = spojenyString.Replace("World", "C#");
            Console.WriteLine("Nahrazený string: " + nahrazenyString);

            // Porovnání bez ohledu na velikost písmen
            prvniString = "Hello";
            druhyString = "hello";

            bool jsouStejneIgnoreCase =
                                           prvniString.Equals(druhyString, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Jsou stejné bez ohledu na velikost písmen: " + jsouStejneIgnoreCase);

            // Porovnání s ohledem na velikost písmen
            bool jsouStejneCaseSensitive = prvniString.Equals(druhyString, StringComparison.Ordinal);
            Console.WriteLine("Jsou stejné s ohledem na velikost písmen: "
            + jsouStejneCaseSensitive);

            // Porovnání s pomocí operátoru ==
            bool jsouStejneOperator = (prvniString == druhyString);
            Console.WriteLine("Jsou stejné pomocí operátoru ==: " + jsouStejneOperator);

            // Porovnání s pomocí Compare metody
            int vysledekPorovnani =
                            String.Compare(prvniString, druhyString, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Výsledek porovnání pomocí Compare metody: " + vysledekPorovnani);

            // Porovnání prefixu
            bool zacinaPrefixem = prvniString.StartsWith("He");
            Console.WriteLine("Začíná prefixem 'He': " + zacinaPrefixem);

            // Porovnání koncovky
            bool konciKoncovkou = prvniString.EndsWith("lo");
            Console.WriteLine("Končí koncovkou 'lo': " + konciKoncovkou);


            // Vytvoření regulárního výrazu
            string pattern = @"(\d+)";
            Regex regex = new Regex(pattern);

            // Vyhledání shody v řetězci
            string input = "Číslo objektu: 12345";
            Match match = regex.Match(input);

            // Výpis informací o shodě
            Console.WriteLine("Vyhledání shody:");
            Console.WriteLine("Celý výraz: " + match.Value);
            Console.WriteLine("Index začátku shody: " + match.Index);
            Console.WriteLine("Délka shody: " + match.Length);

            // Vyhledání všech shod v řetězci
            Console.WriteLine("\nVyhledání všech shod:");
            foreach (Match m in regex.Matches(input))
            {
                Console.WriteLine("Shoda: " + m.Value + ", Index: " + m.Index);
            }

            // Nahrazení shody v řetězci
            string replaced = regex.Replace(input, "X");
            Console.WriteLine("\nNahrazený řetězec: " + replaced);

            // Test, zda řetězec odpovídá regulárnímu výrazu
            string testString = "456";
            bool isMatch = regex.IsMatch(testString);
            Console.WriteLine("\nOdpovídá řetězec regulárnímu výrazu? " + isMatch);

            // Rozdělení řetězce pomocí regulárního výrazu
            string splitInput = "Jedna, Dvě, Tři";
            string[] splitResult = regex.Split(splitInput);
            Console.WriteLine("\nRozdělený řetězec:");
            foreach (string part in splitResult)
            {
                Console.WriteLine(part);
            }

            string text = "Hello, world!";
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(text);

            Console.WriteLine("UTF-8 bytes:");
            foreach (byte b in utf8Bytes)
            {
                Console.Write($"{b:X2} ");
            }
            // decode
            //utf8Bytes = { b:72, 101, 108, 108, 111, 44, 32, 119, 111, 114, 108, 100, 33 };
            string decodedText = Encoding.UTF8.GetString(utf8Bytes);

            Console.WriteLine("Decoded text: " + decodedText);
            // another
            text = "Ahoj, světe!";
            byte[] isoBytes = Encoding.GetEncoding("ISO-8859-2").GetBytes(text);

            Console.WriteLine("ISO-8859-2 bytes:");
            foreach (byte b in isoBytes)
            {
                Console.Write($"{b:X2} ");
            }

            // Parsování čísel ze stringu
            string numberString = "123 456 789";
            string[] numbers = numberString.Split(' ');

            Console.WriteLine("Parsovaná čísla:");
            foreach (string num in numbers)
            {
                if (int.TryParse(num, out int parsedNumber))
                {
                    Console.WriteLine(parsedNumber);
                }
                else
                {
                    Console.WriteLine($"Nelze zparsovat: {num}");
                }
            }

            // Manipulace s řetězci
            string originalString = "   Hello, world!   ";
            string trimmedString = originalString.Trim();

            Console.WriteLine("\nTrimovaný řetězec:");
            Console.WriteLine(trimmedString);

            // Zpracování datumu
            string dateString = "2023-12-01";
            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                Console.WriteLine("\nZparsované datum:");
                Console.WriteLine(parsedDate.ToString("MMMM dd, yyyy"));
            }
            else
            {
                Console.WriteLine("\nNelze zparsovat datum.");
            }

            prvniString = "Hello";
            druhyString = "World";
            spojenyString = prvniString + " " + druhyString;
            spojenyString = string.Concat(prvniString, " ", druhyString);
            spojenyString = string.Join(" ", prvniString, druhyString);

        }
    }
}