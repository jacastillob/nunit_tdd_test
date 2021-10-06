using System;
using System.Collections.Generic;

namespace solid.s.before {
   
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

        public double Sum()
        {
            double sum = 0;
            foreach (var item in shapes)
            {
                if(item is Square)
                {
                    sum = Math.Pow(((Square)item).length,2);
                }else if (item is Circle)
                {
                    sum = ((Math.PI ) * Math.Pow(((Circle)item).radius, 2));
                }

            }

            return sum;
        }
        // this function does not belong to the AreaCalculator responsability!!!
        public string output()
        {
            return $" Sum of the areas of provided shapes: {Sum()}";
        }


    }
    class RunMain
    {
        static void Main(string[] args)
        {
          List<Object> shapes= new List<Object>(){
                                      new Circle(2),
                                      new Square(5),
                                      new Square(6),
                                    };

         AreaCalculator  areas= new AreaCalculator(shapes);
         // AreaCalulator single responsability is to calculate areas rather than outputting.
         // This would violate the single - responsibility principle
         Console.WriteLine(areas.output());

        }
    }


}

