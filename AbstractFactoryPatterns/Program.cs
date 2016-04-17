using AbstractFactoryPatterns.Color;
using AbstractFactoryPatterns.Shape;
using System;

namespace AbstractFactoryPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IDrawable shapeFactory = FactoryProducer.getFactory("shape");
            IDrawable colorFactory = FactoryProducer.getFactory("color");
            IShape shape;
            IColor color;
            string shapeName;
            string colorName;

            while (true)
            {
                Console.Write("Enter what shape to put on canvass: ");
                shapeName = Console.ReadLine();
                Console.Write("Enter what color to put on shape: ");
                colorName = Console.ReadLine();

                try
                {
                    shape = shapeFactory.GetShape(shapeName);
                    color = colorFactory.GetColor(colorName);
                    shape.draw();
                    color.fill();
                }
                catch (NotImplementedException e)
                {
                    Console.WriteLine("sorry, this is not yet implemented.");
                }

                Console.WriteLine();
            }
        }
    }
}