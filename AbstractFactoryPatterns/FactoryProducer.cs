using AbstractFactoryPatterns.Factory;
using System;

namespace AbstractFactoryPatterns
{
    internal class FactoryProducer
    {
        public static IDrawable getFactory(string factoryChoice)
        {
            if (string.Equals(factoryChoice, "SHAPE", StringComparison.OrdinalIgnoreCase))
            {
                return new ShapeFactory();
            }
            else if (string.Equals(factoryChoice, "COLOR", StringComparison.OrdinalIgnoreCase))
            {
                return new ColorFactory();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}