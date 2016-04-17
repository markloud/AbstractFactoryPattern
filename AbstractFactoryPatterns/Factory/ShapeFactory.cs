using AbstractFactoryPatterns.Color;
using AbstractFactoryPatterns.Shape;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AbstractFactoryPatterns.Factory
{
    internal class ShapeFactory : IDrawable
    {
        private Dictionary<string, Type> autos;

        public ShapeFactory()
        {
            LoadTypesICanReturn();
        }

        private void LoadTypesICanReturn()
        {
            autos = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes(); // use reflection to get all types in assembly

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IShape).ToString()) != null)
                {
                    autos.Add(type.Name.ToUpper(), type); // adds the type as key & the type itself
                }
            }
        }

        public IShape GetShape(string shapeType)
        {
            Type t = null;
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(shapeType))
                {
                    t = autos[auto.Key];
                }
            }

            return Activator.CreateInstance(t) as IShape;
        }

        public IColor GetColor(string color)
        {
            return null;
        }
    }
}