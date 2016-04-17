using System;

namespace NoFactory.Shape
{
    internal class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("\tInside Rectangle::draw() method.");
        }
    }
}