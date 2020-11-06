using System;

namespace SimpleFactory.Shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.Out.WriteLine("Inside Square::draw() method.");
        }
    }
}