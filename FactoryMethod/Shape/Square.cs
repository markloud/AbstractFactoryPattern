using System;

namespace FactoryMethod.Shape
{
    internal class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}