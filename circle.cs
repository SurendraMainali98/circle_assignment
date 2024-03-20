using System;

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetSurface()
    {
        return Math.PI * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of circles you want to create: ");
        int numCircles = int.Parse(Console.ReadLine());

        Circle[] circles = new Circle[numCircles];

        for (int i = 0; i < numCircles; i++)
        {
            Console.WriteLine("Enter the radius of circle " + (i + 1) + ": ");
            double radius = double.Parse(Console.ReadLine());
            circles[i] = new Circle(radius);
        }

        Console.WriteLine("Enter a point to check if it is inside any of the circles: ");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        for (int i = 0; i < numCircles; i++)
        {
            Circle circle = circles[i];
            if (circle.GetSurface() > 0 && circle.GetPerimeter() > 0)
            {
                double distance = Math.Sqrt(Math.Pow(x - circle.radius, 2) + Math.Pow(y - circle.radius, 2));
                if (distance <= circle.radius)
                {
                    Console.WriteLine("The point (" + x + ", " + y + ") is inside circle " + (i + 1));
                }
            }
        }
    }
}