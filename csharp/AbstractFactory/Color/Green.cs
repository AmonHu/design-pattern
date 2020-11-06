using System;

namespace AbstractFactory.Color
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.Out.WriteLine("Inside Green::fill() method.");
        }
    }
}