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
            ShapeFactory shapeFactory = new ShapeFactory(); // client knows what family of products to use

            IShape shape1 = shapeFactory.GetShape("CIRCLE"); // implementation depends on the GetShape Factory Method
            shape1.draw();

            IShape shape2 = shapeFactory.GetShape("RECTANGLE");
            shape2.draw();

            IShape shape3 = shapeFactory.GetShape("SQUARE");
            shape3.draw();

            Console.ReadKey();
        }
    }
}