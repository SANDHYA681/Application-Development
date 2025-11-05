using System;

class Circle
{
    const double PI = 3.14; 
    public static void Main()
    {
        double radius = 4.0;
        double area = PI * radius * radius;
        Console.WriteLine($"The area of the circle is {area}");
    }
}
