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
        }
    }
}
