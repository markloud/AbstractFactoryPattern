using System;
using AbstractFactoryPatterns.Shape;

namespace AbstractFactoryPatterns.Color
{
    internal class Green : IColor
    {
        public void fill()
        {
            Console.WriteLine("\tInside Green::fill() method.");
        }
    }
}