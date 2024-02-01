using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    abstract class Figure
    {
        public abstract double Area();
    }

    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }

    class RightTriangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public RightTriangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height / 2;
        }
    }

    class Trapezium : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Base { get; set; }

        public Trapezium(double width, double height, double _base)
        {
            Width = width;
            Height = height;
            Base = _base;
        }

        public override double Area()
        {
            return (Base + Width) * Height / 2;
        }
    }

    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    internal class Figures
    {
        public void Main()
        {
            Rectangle rectangle = new Rectangle(10, 20);
            RightTriangle rightTriangle = new RightTriangle(10, 20);
            Trapezium trapezium = new Trapezium(10, 20, 30);
            Circle circle = new Circle(10);

            Console.WriteLine($"Rectangle area: {rectangle.Area()}");
            Console.WriteLine($"RightTriangle area: {rightTriangle.Area()}");
            Console.WriteLine($"Trapezium area: {trapezium.Area()}");
            Console.WriteLine($"Circle area: {circle.Area()}");
        }
    }
}
