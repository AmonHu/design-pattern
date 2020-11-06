using System;

namespace AbstractFactory.Shapes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.Out.WriteLine("Inside Circle::draw() method.");
        }
    }
}