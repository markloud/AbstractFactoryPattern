using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterns.Color
{
    class Red : IColor
    {
        public void fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}
