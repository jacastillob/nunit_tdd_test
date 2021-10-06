using System;
using System.Collections.Generic;

namespace solid.o.after
{
    public interface ShapeInterface
    {
        double area();
    }

    public class Square : ShapeInterface
    {
        public double length;

        public Square(double length)
        {
            this.length = length;
        }

        public double area()
        {
            return (Math.Pow(length, 2));
        }
    }
    public class Circle : ShapeInterface
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double area()
        {
            return ((Math.PI) * Math.Pow(radius, 2));
        }
    }

    public class AreaCalculator
    {
        protected List<ShapeInterface> shapes;

        public AreaCalculator(List<ShapeInterface> shapes)
        {
            this.shapes = shapes;
        }

        // With the new interfaces more shapes can be included and that satisfies the open-closed principle
        public double Sum()
        {
            double sum = 0;
            foreach (var shape in shapes)
            {
                sum += shape.area();
            }

            return sum;
        }
    }

    /// This class handles only the output, it is its own responsability
    /// </summary>
    public class SumCalculatorOutputter
    {
        protected AreaCalculator calculator;

        public SumCalculatorOutputter(AreaCalculator calculator)
        {
            this.calculator = calculator;
        }

        public string JSON()
        {
            return "";
        }

        public string HTML()
        {
            return $" Sum of the areas of provided shapes: {calculator.Sum()}";
        }

    }
    class RunMain
    {
        static void Main(string[] args)
        {

            List<ShapeInterface> shapes = new List<ShapeInterface>(){
                                                  new Circle(2),
                                                  new Square(5),
                                                  new Square(6),
                                             };

            AreaCalculator areas = new AreaCalculator(shapes);
            SumCalculatorOutputter output = new SumCalculatorOutputter(areas);
            Console.WriteLine(output.JSON());
            Console.WriteLine(output.HTML());

        }
    }


}

