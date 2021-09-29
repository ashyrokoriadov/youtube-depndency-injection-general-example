using DependencyInjectionSampeApp.Interfaces;
using System;

namespace DependencyInjectionSampeApp.Implementations
{
    class Calculator : ICalculator
    {
        private readonly IPrinter _printer;
        private readonly IConnector _connector;

        public Calculator(IPrinter printer, IConnector connector)
        {
            _printer = printer ?? throw new ArgumentNullException(nameof(printer));
            _connector = connector ?? throw new ArgumentNullException(nameof(connector));
        }

        public void Calculate()
        {
            Console.WriteLine($"Вызван метод {nameof(Calculate)} класса {nameof(Calculator)}.");
            _connector.Connect();
            _printer.Print();
            //логика метода Calculate
        }
    }
}
