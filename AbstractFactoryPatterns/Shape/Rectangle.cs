using System;

namespace AbstractFactoryPatterns.Shape
{
    internal class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}