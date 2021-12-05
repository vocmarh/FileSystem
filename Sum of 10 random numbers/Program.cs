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
            string path = "C:/Users/vocma/YandexDisk/Рабочая/НИПИГОРМАШ/Малмыж/Test/test.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                int Min = 0;
                int Max = 100;

                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {                    
                    int number = random.Next(Min, Max);
                    array[i] = number;
                    sw.WriteLine(number);         
                    
                }
                int sum = array.Sum();
                Console.WriteLine(sum);

            }
            


            Console.ReadKey();

        }
    }
}
