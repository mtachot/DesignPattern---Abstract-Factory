using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Green");
            Console.ReadLine();
        }
    }
}
