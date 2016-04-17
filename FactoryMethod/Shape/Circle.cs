﻿using System;

namespace FactoryMethod.Shape
{
    internal class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("\tInside Circle::draw() method.");
        }
    }
}