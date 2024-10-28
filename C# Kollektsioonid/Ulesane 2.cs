using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Kollektsioonid
{
    public class Ulesane_2
    {
        public static void ul2()
        {
            Console.WriteLine("Ülesanne 2");

            Random rnd = new Random();  
            
            List<int> numbers = new List<int> { };

            for (int i = 0; i < 20; i++)
            {
                int a = rnd.Next(1,200);
                numbers.Add(a);
            }

            List<int> sortNumbers = numbers.Where(n => n % 2 == 0).ToList();
            sortNumbers.AddRange(numbers.Where(n => n % 2 != 0));


            Console.WriteLine("Tavaline nimekiri: ");
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine("Sorteeritud nimekiri: ");
            Console.WriteLine(string.Join(" ", sortNumbers));
        }
    }
}
