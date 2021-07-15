using System;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            string radiusInput = Console.ReadLine();
            double r = double.Parse(radiusInput);
            double pi = Math.PI;
            double area = pi * r * r;
            Console.WriteLine("The area of a cricle of the radius " + r + " is " + Math.Round(area, 2));
            double circumference = 2 * pi * r;
            double diameter = 2 * r;
            Console.WriteLine("The circumference of the circle is " + Math.Round(circumference, 2) + " and the diamter of the circle is " + Math.Round(diameter, 2));

            Console.WriteLine("What are the miles per gallon of your car?");
            string mpg = Console.ReadLine();
            double gasAmount =  circumference / double.Parse(mpg);
            Console.WriteLine("It would require you " +  Math.Round(gasAmount, 2) +" gallons of gas to drive around the circle.");
        }
    }
}
