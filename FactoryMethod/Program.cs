using FactoryMethod.Factory;
using FactoryMethod.Shape;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // get shape factory
            ShapeFactory shapeFactory = new ShapeFactory(); // client knows what family of products to use
            string shapeName;
            IShape shape; // implementation depends on the GetShape Factory Method
            
            while (true)
            {
                Console.Write("Enter shape: ");
                shapeName = Console.ReadLine();

                try {
                    shape = shapeFactory.GetShape(shapeName);
                    shape.draw();
                }
                catch (NotImplementedException e)
                {
                    Console.WriteLine("sorry, shape is not yet implemented.");
                }
            }
        }
    }
}