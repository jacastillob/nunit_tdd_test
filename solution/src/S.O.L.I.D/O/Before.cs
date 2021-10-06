using System;
using System.Collections.Generic;

namespace solid.o.before
{

    public class Square
    {
        public double length;

        public Square(double length)
        {
            this.length = length;
        }

    }
    public class Circle
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
    }

    public class AreaCalculator
    {
        protected List<Object> shapes;

        public AreaCalculator(List<Object> shapes)
        {
            this.shapes = shapes;
        }

        // There is an issue here, because if more shapes are created, this code will need to be modified plenty of times
        public double Sum()
        {
            double sum = 0;
            foreach (var item in shapes)
            {
                if (item is Square)
                {
                    sum = Math.Pow(((Square)item).length, 2);
                }
                else if (item is Circle)
                {
                    sum = ((Math.PI) * Math.Pow(((Circle)item).radius, 2));
                }
            }
            return sum;
        }
    }

    /// <summary>
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
            List<Object> shapes = new List<Object>(){
                                      new Circle(2),
                                      new Square(5),
                                      new Square(6),
                                    };

            AreaCalculator areas = new AreaCalculator(shapes);
            SumCalculatorOutputter output = new SumCalculatorOutputter(areas);
            // Now the logic belongs to eachs class and that satisfies the single responsibility principle
            Console.WriteLine(output.JSON());
            Console.WriteLine(output.HTML());

        }
    }
}
