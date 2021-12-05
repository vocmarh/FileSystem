using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 100;

            int[] array = new int[10];

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(Min, Max);
                Console.WriteLine(random.Next(Min, Max));
            }

            int sum = array.Sum();
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
