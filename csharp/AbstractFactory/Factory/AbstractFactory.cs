using AbstractFactory.Color;
using AbstractFactory.Shapes;

namespace AbstractFactory.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor();
        public abstract IShape GetShape();
    }
}