using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add the data of the sides:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            var rectangleArea = a * b;
            Console.WriteLine("The area = {0}", rectangleArea);
        }
    }
}
