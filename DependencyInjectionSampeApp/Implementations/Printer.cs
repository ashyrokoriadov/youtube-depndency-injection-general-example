using DependencyInjectionSampeApp.Interfaces;
using System;

namespace DependencyInjectionSampeApp.Implementations
{
    class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine($"Вызван метод {nameof(Print)} класса {nameof(Printer)}.");
            //логика метода Print
        }
    }
}
