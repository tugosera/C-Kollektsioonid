using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Kollektsioonid
{
    public class MainClass
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("ülesanne 1");
            Console.WriteLine("Sissesta numbrid (kasuta space)");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                int[] result = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    int left = numbers[(i - 1 + numbers.Length) % numbers.Length];
                    int right = numbers[(i + 1) % numbers.Length];
                    result[i] = left + right;
                }

               Console.WriteLine(string.Join(" ", result));
            }
            Console.WriteLine();
            Ulesane_2.ul2();



            Ulesanne_4 estonia = new Ulesanne_4();

            while (true)
            {
                Console.WriteLine("\nValige toiming:");
                Console.WriteLine("1. Näidata pealinna maakonna nime järgi");
                Console.WriteLine("2. Näita maakonda pealinna nime järgi");
                Console.WriteLine("3. Lisa uus maakond ja pealinn");
                Console.WriteLine("4. Testida teadmisi maakondade ja pealinnade kaupa");
                Console.WriteLine("5. Väljapääs");
                Console.Write("Teie valik: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Sisesta maakonna nimi: ");
                        string county = Console.ReadLine();
                        estonia.ShowCapital(county);
                        break;
                    case "2":
                        Console.Write("Sisesta pealinna nimi: ");
                        string capital = Console.ReadLine();
                        estonia.ShowCounty(capital);
                        break;
                    case "3":
                        estonia.AddCounty();
                        break;
                    case "4":
                        estonia.TestKnowledge();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Vale valik, proovi uuesti.");
                        break;
                }
            }
        }
    }
}
