using AbstractFactoryPatterns.Color;
using AbstractFactoryPatterns.Shape;

namespace AbstractFactoryPatterns
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    internal interface IDrawable
    {
        IColor GetColor(string color); // Factory Method 1
        IShape GetShape(string shape); // Factory Method 2
    }
}