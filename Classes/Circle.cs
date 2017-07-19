using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
            Console.ReadLine();
        }
    }
}
