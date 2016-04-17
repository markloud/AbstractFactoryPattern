using FactoryMethod.Factory;
using FactoryMethod.Shape;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //get shape factory
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.GetShape("CIRCLE");
            shape1.draw();

            IShape shape2 = shapeFactory.GetShape("RECTANGLE");
            shape2.draw();

            IShape shape3 = shapeFactory.GetShape("SQUARE");
            shape3.draw();

            Console.ReadKey();
        }
    }
}