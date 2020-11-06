using AbstractFactory.Color;
using AbstractFactory.Shapes;

namespace AbstractFactory.Factory
{
    public class RedSquareFactory : AbstractFactory
    {
        public override IColor GetColor()
        {
            return new Red();
        }

        public override IShape GetShape()
        {
            return new Square();
        }
    }
}