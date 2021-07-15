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
            Console.WriteLine("The area of a cricle of the radius " + r + " is " + Math.Round(Circle.GetArea(r), 2));
            Console.WriteLine("The circumference of the circle is " + Math.Round(Circle.GetCircumference(r), 2) + " and the diamter of the circle is " + Math.Round(Circle.GetDiameter(r), 2));
            Console.WriteLine("What are the miles per gallon of your car?");
            string mpg = Console.ReadLine();
            double gasAmount =  Circle.GetCircumference(r) / double.Parse(mpg);
            Console.WriteLine("It would require you " +  Math.Round(gasAmount, 2) +" gallons of gas to drive around the circle.");
        }
    }
}
