using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory.Factories.AbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");
            AbstractFactory.Factories.AbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");
            
            IShape shape1 = shapeFactory.getShape("RECTANGLE");
            IShape shape2 = shapeFactory.getShape("CIRCLE");
            IShape shape3 = shapeFactory.getShape("SQUARE");
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();

            IColor color1 = colorFactory.getColor("RED");
            IColor color2 = colorFactory.getColor("GREEN");
            IColor color3 = colorFactory.getColor("BLUE");
            color1.Fill();
            color2.Fill();
            color3.Fill();
        }
    }
}
