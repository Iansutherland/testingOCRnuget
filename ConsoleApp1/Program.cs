using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patagames.Ocr;
using System.Drawing;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = @"Pic/Untitled.png";

            if (File.Exists(picPath))
            {
                using(var ocr = OcrApi.Create())
                {
                    ocr.Init(Patagames.Ocr.Enums.Languages.English);

                    string plainText = ocr.GetTextFromImage(picPath);

                    Console.WriteLine(plainText);
                }
            }
            else
            {
                Console.WriteLine($"Couldn't find {picPath}");
            }

            Console.ReadLine();
        }
    }
}
