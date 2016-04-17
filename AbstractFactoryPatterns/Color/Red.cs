using System;

namespace AbstractFactoryPatterns.Color
{
    internal class Red : IColor
    {
        public void fill()
        {
            Console.WriteLine("\tInside Red::fill() method.");
        }
    }
}