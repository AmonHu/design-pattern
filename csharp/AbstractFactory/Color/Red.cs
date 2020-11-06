using System;

namespace AbstractFactory.Color
{
    public class Red : IColor
    {
        public void Fill()
        {
            Console.Out.WriteLine("Inside Red::fill() method.");
        }
    }
}