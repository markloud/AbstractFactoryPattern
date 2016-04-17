using System;

namespace AbstractFactoryPatterns.Color
{
    internal class Blue : IColor
    {
        public void fill()
        {
            Console.WriteLine("\tInside Blue::fill() method.");
        }
    }
}