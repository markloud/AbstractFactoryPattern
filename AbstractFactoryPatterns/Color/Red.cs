using System;

namespace AbstractFactoryPatterns.Color
{
    internal class Red : IColor
    {
        public void fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}