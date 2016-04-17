using System;

namespace AbstractFactoryPatterns.Shape
{
    internal class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}