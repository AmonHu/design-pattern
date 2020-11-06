using System;
using SimpleFactory.Shapes;

namespace SimpleFactory
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            return shapeType switch
            {
                "Circle" => new Circle(),
                "Rectangle" => new Rectangle(),
                "Square" => new Square(),
                _ => null,
            };
        }
    }
}