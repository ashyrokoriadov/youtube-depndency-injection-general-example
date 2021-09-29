using DependencyInjectionSampeApp.Interfaces;
using System;

namespace DependencyInjectionSampeApp.Implementations
{
    class Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine($"Вызван метод {nameof(Log)} класса {nameof(Logger)}.");
            //логика метода Log
        }
    }
}
