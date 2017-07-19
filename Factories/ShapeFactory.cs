using AbstractFactory.Classes;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    class ShapeFactory : AbstractFactory
    {
        public override IShape getShape(string shapeType)
        {
            if (String.IsNullOrEmpty(shapeType))
                return null;

            if (shapeType.ToUpper() == "CIRCLE")
                return new Circle();

            if (shapeType.ToUpper() == "RECTANGLE")
                return new Rectangle();

            if (shapeType.ToUpper() == "SQUARE")
                return new Square();

            return null;
        }

        public override IColor getColor(string color)
        {
            return null;
        }
    }
}
