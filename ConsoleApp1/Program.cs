using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytutorial.com.getfilesexample
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo objDirectoryInfo = new DirectoryInfo("C:/Users/vocma/YandexDisk/Рабочая/НИПИГОРМАШ/Малмыж");
            FileInfo[] allFiles = objDirectoryInfo.GetFiles("*.*", SearchOption.AllDirectories);           

            foreach (var file in allFiles)
            {
                Console.WriteLine(file.Name + ", Full Path: " + file.FullName);
            }

            Console.ReadLine();
        }
    }
}