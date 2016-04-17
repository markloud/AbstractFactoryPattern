using NoFactory.Shape;
using System;

namespace SimpleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string shapeName = "";
            IShape shape;

            while(true)
            {
                Console.Write("Enter shape: ");
                shapeName = Console.ReadLine();

                shape = GetShape(shapeName);
                shape.draw();
            }
        }

        private static IShape GetShape(string shapeName) // violates OCP
        {
            switch (shapeName) // everytime we add a new implementation of IShape, we have to modify this client
            {
                case "circle":
                    return new Circle();
                case "square":
                    return new Square();
                case "rectangle":
                    return new Rectangle();
                default:
                   throw new NotImplementedException();
            }
        }
    }
}