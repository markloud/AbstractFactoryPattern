using System;
using AbstractFactoryPatterns.Shape;

namespace AbstractFactoryPatterns.Color
{
    internal class Green : IColor
    {
        public void fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}