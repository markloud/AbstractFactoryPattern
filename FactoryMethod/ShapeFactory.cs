using FactoryMethod.Shape;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryMethod.Factory
{
    internal class ShapeFactory
    {
        private Dictionary<string, Type> shapes;

        public ShapeFactory() // loads all instance of IShape upon construction
        {
            LoadTypesICanReturn();
        }

        private void LoadTypesICanReturn()
        {
            shapes = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes(); // use reflection to get all types in assembly

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IShape).ToString()) != null)
                {
                    shapes.Add(type.Name.ToUpper(), type); // adds the type as key & the type itself
                }
            }
        }

        public IShape GetShape(string shapeType) // Factory Method
        {
            Type t = null;
            foreach (var auto in shapes)
            {
                if (auto.Key.Contains(shapeType.ToUpper()))
                {
                    t = shapes[auto.Key];
                }
            }

            if (t == null)
                throw new NotImplementedException();

            return Activator.CreateInstance(t) as IShape;
        }
    }
}