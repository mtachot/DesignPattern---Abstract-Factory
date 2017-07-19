using AbstractFactory.Classes;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class ColorFactory : AbstractFactory
    {
        public override IShape getShape(string shapeType)
        {
            return null;
        }

        public override IColor getColor(string color)
        {
            if (String.IsNullOrEmpty(color))
                return null;

            if (color.ToUpper() == "BLUE")
                return new Blue();

            if (color.ToUpper() == "GREEN")
                return new Green();

            if (color.ToUpper() == "RED")
                return new Red();

            return null;
        }
    }
}
