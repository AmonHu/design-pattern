using AbstractFactory.Color;
using AbstractFactory.Shapes;

namespace AbstractFactory.Factory
{
    public class BlueCircleFactory:AbstractFactory
    {
        public override IColor GetColor()
        {
            return new Blue();
        }

        public override IShape GetShape()
        {
            return new Circle();
        }
    }
}