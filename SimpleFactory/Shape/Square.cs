using System;

namespace NoFactory.Shape
{
    internal class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("\tInside Square::draw() method.");
        }
    }
}