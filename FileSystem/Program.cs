using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {    
            
            string[] directories = Directory.GetDirectories("C:/Users/vocma/YandexDisk/Рабочая/НИПИГОРМАШ/Малмыж");
            foreach(string directoryname in directories)
            {                
                Console.WriteLine(directoryname);                
            }
            Console.WriteLine();

            DirectoryInfo objDirectoryInfo = new DirectoryInfo("C:/Users/vocma/YandexDisk/Рабочая/НИПИГОРМАШ/Малмыж");
            FileInfo[] allFiles = objDirectoryInfo.GetFiles("*.*", SearchOption.AllDirectories);

            foreach (var file in allFiles)
            {
                Console.WriteLine(file.Name);
            }

            Console.ReadKey();

        }
    }
}
