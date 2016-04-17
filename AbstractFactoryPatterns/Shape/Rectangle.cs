﻿using System;

namespace AbstractFactoryPatterns.Shape
{
    internal class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("\tInside Rectangle::draw() method.");
        }
    }
}