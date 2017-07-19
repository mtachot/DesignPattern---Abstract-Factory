using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (String.IsNullOrEmpty(choice))
                return null;

            if (choice.ToUpper() == "COLOR")
                return new ColorFactory();

            if (choice.ToUpper() == "SHAPE")
                return new ShapeFactory();

            return null;
        }
    }
}
