using System;

public class Exercise_6
{
    public static void Run()
    {
        double length, breadth, rectArea;
        double side, squareArea;

        // Rectangle
        Console.Write("Enter length of rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth of rectangle: ");
        breadth = Convert.ToDouble(Console.ReadLine());

        rectArea = length * breadth;

        // Square
        Console.Write("Enter side of square: ");
        side = Convert.ToDouble(Console.ReadLine());

        squareArea = side * side;

        Console.WriteLine("Area of Rectangle = " + rectArea);
        Console.WriteLine("Area of Square = " + squareArea);
    }
}