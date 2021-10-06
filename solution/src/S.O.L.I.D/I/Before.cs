using System;
namespace solid.i.before
{
    interface ShapeInterface
    {
         double area();
         double volume();
    }

    /// <summary>
    /// Square is a flat surface and do not have volume, so this interface would force to implemente a method  that it has no use of -> volumen
    /// </summary>
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

        public double volume()
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// Square is a flat surface and do not have volume, so this interface would force to implemente a method  that it has no use of -> volumen
    /// </summary>
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

        public double volume()
        {
            throw new NotImplementedException();
        }
    }

    public class Cuboid : ShapeInterface
    {
        public double area()
        {
            throw new NotImplementedException();
        }

        public double volume()
        {
            throw new NotImplementedException();
        }
    }

}
