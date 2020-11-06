using System;

namespace SimpleFactory.Shapes
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.Out.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}