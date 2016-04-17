using AbstractFactoryPatterns.Color;
using AbstractFactoryPatterns.Shape;
using System;

namespace AbstractFactoryPatterns.Factory
{
    internal class ColorFactory : IDrawable
    {
        public IColor GetColor(string color)
        {
            if (string.Equals(color, "RED", StringComparison.OrdinalIgnoreCase))
            {
                return new Red();
            }
            else if (string.Equals(color, "GREEN", StringComparison.OrdinalIgnoreCase))
            {
                return new Green();
            }
            else if (string.Equals(color, "BLUE", StringComparison.OrdinalIgnoreCase))
            {
                return new Blue();
            }
            else
            {
                return null;
            }
        }

        public IShape GetShape(string shapeType)
        {
            return null;
        }
    }
}