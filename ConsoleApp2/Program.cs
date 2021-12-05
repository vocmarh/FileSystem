using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sum_of_10_random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine(random.Next(0, 100));
                Array.ForEach(array, delegate (int a) { sum += i; });
            }



            Console.ReadKey();

        }
    }
}
