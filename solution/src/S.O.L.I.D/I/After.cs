using System;
namespace solid.i.after
{
    interface ShapeInterface
    {
        double area();
    }
    interface ThreeDimensionalShapeInterface
    {  
        double volume();
    }
    interface ManageShapeInterface
    {
        double calculate();
    }



    public class Square : ShapeInterface,ManageShapeInterface
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

        public double calculate()
        {
            return this.area();
        }
    }

    public class Circle : ShapeInterface,ManageShapeInterface
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

        public double calculate()
        {
            return this.area();
        }
    }

    public class Cuboid : ShapeInterface, ThreeDimensionalShapeInterface, ManageShapeInterface
    {
        public double area()
        {
            throw new NotImplementedException();
        }

        public double calculate()
        {
            return this.area();
        }

        public double volume()
        {
            throw new NotImplementedException();
        }
    }

}
