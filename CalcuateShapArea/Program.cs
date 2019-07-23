using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcuateShapArea
{

    public interface IShape
    {
        double CalculateAreaOfShape();
    }

    public class Circle : IShape
    {
        private double pi = 3.14, radius;

        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateAreaOfShape()
        {
            return pi * radius * radius;
        }

       
    }

   

    public class Rectangle : IShape
    {
        private double length, width, height;
        public Rectangle(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public double CalculateAreaOfShape()
        {
            return length*width*height;
        }
    }

    public class Square : IShape
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public double CalculateAreaOfShape()
        {
            return side * side;
        }
    }

    public class Triangle : IShape
    {
        private double width, height;
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculateAreaOfShape()
        {
            return (width * height) / 2;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
