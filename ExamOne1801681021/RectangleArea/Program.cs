using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program will calculate an area of a rectangle!");
            Random number = new Random();
            int length = number.Next(1, 50);
            int wigth = number.Next(51, 100);
            int area = length * wigth;
            Console.WriteLine($"The random area of the rectangle is: {area:0}");
        }
    }
}
