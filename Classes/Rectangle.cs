using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle");
            Console.ReadLine();
        }
    }
}
