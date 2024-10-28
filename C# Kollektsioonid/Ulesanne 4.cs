using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Kollektsioonid
{
    public class Ulesanne_4
    {

        private Dictionary<string, string> counties = new Dictionary<string, string>()
    {
        { "Harju", "Tallinn" },
        { "Tartu", "Tartu" },
        { "Ida-Viru", "Jõhvi" },
        { "Pärnu", "Pärnu" },
        { "Viljandi", "Viljandi" }
    };

        public void ShowCapital(string county)
        {
            if (counties.ContainsKey(county))
            {
                Console.WriteLine($"Maakonna pealinn {county}: {counties[county]}");
            }
            else
            {
                Console.WriteLine($"Maakond {county} ei ole sõnaraamatust leitud.");
                AddCounty(county);
            }
        }

        public void ShowCounty(string capital)
        {
            string county = counties.FirstOrDefault(c => c.Value == capital).Key;
            if (county != null)
            {
                Console.WriteLine($"Pealinna maakond {capital}: {county}");
            }
            else
            {
                Console.WriteLine($"Pealinn {capital} ei ole sõnaraamatust leitud.");
                AddCounty(countyName: null, capital: capital);
            }
        }

        public void AddCounty(string countyName = null, string capital = null)
        {

            Console.Write("Sisesta maakonna nimi: ");
            countyName = Console.ReadLine();
            Console.Write("Sisesta pealinna nimi: ");
            capital = Console.ReadLine();
        }

        public void TestKnowledge()
        {
            Random random = new Random();
            int correctAnswers = 0;

            Console.WriteLine("Maakondade ja pealinnade tundmise test. Sisesta pealinna maakonnale või maakonnale pealinn:");

            foreach (var item in counties.OrderBy(x => random.Next()))
            {
                Console.Write($"Sisesta {item.Key} pealinn: ");
                string answer = Console.ReadLine();

                if (answer.Equals(item.Value, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Õigus!");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine($"Valesti. Õige vastus: {item.Value}");
                }
            }
            Console.WriteLine($"Teie tulemus: {correctAnswers} väljast {counties.Count}");
        }
    }
}