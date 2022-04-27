using System;
using System.IO;
using Utilities;

namespace ConsoleApp9
{
    public class Program
    {
        static void Main(string[] args)
        {

            var file = File.ReadAllBytes("C:\\Users\\Szelma\\Pictures\\ooo.jpg");
            var k = ImageUtilities.GetSizefromImage(file);
            Console.WriteLine("Hello World!");
            Console.WriteLine(k.Height.ToString());
            Console.WriteLine(k.Width.ToString());

            file = File.ReadAllBytes("C:\\Users\\Szelma\\Pictures\\image.png");
             k = ImageUtilities.GetSizefromImage(file);
            Console.WriteLine("Hello World!");
            Console.WriteLine(k.Height.ToString());
            Console.WriteLine(k.Width.ToString());

            file = File.ReadAllBytes("C:\\Users\\Szelma\\Pictures\\fff.png");

            k = ImageUtilities.GetSizefromImage(file);
            Console.WriteLine("Hello World!");
            Console.WriteLine(k.Height.ToString());
            Console.WriteLine(k.Width.ToString());

            file = File.ReadAllBytes("C:\\Users\\Szelma\\Pictures\\aaa.png");

            k = ImageUtilities.GetSizefromImage(file);
            Console.WriteLine("Hello World!");
            Console.WriteLine(k.Height.ToString());
            Console.WriteLine(k.Width.ToString());

        }
    }
}
