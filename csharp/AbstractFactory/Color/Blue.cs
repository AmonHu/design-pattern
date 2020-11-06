using System;

namespace AbstractFactory.Color
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.Out.WriteLine("Inside Blue::fill() method.");
        }
    }
}