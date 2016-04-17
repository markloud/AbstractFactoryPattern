using AbstractFactoryPatterns.Color;
using AbstractFactoryPatterns.Shape;
using System;

namespace AbstractFactoryPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //get shape factory
            IDrawable shapeFactory = FactoryProducer.getFactory("SHAPE");

            IShape shape1 = shapeFactory.GetShape("CIRCLE");
            shape1.draw();

            IShape shape2 = shapeFactory.GetShape("RECTANGLE");
            shape2.draw();

            IShape shape3 = shapeFactory.GetShape("SQUARE");
            shape3.draw();

            Console.WriteLine();

            //get color factory
            IDrawable colorFactory = FactoryProducer.getFactory("COLOR");

            IColor color1 = colorFactory.GetColor("RED");
            color1.fill();

            IColor color2 = colorFactory.GetColor("Green");
            color2.fill();

            IColor color3 = colorFactory.GetColor("BLUE");
            color3.fill();

            Console.ReadKey();
        }
    }
}