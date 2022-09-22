using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IDFK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10;
            double num2 = 1.5;

            double sum = num1 + num2;
            double avg = sum / 2;

            Console.WriteLine(avg);

            num1 = num1 + 7;
            num2 = num2 * 6;


            Console.WriteLine("=========================");


            Console.WriteLine("What year were you born? ");

            int bornYear = Convert.ToInt32(Console.ReadLine());
            int currentYear = 2022;

            int age = currentYear - bornYear;
            Console.WriteLine(age);


            Console.WriteLine("=========================");


            Console.WriteLine("Enter the width of the square: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the lenght of the square: ");
            double lenght = Convert.ToDouble(Console.ReadLine());

            double surfaceArea = lenght * width;
            double perimiter = (lenght + width) * 2;

            Console.WriteLine("The surface area is: " + surfaceArea);
            Console.WriteLine("The perimiter is: " + perimiter);


            Console.WriteLine("=========================");


            Console.ReadKey();
        }
    }
}
