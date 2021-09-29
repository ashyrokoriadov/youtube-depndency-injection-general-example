using DependencyInjectionSampeApp.Interfaces;
using System;

namespace DependencyInjectionSampeApp.Implementations
{
    class XmlConfigurationReader : IConfigurationReader
    {
        private readonly IPrinter _printer;

        public XmlConfigurationReader(IPrinter printer)
        {
            _printer = printer ?? throw new ArgumentNullException(nameof(printer));
        }

        public void Read()
        {
            Console.WriteLine($"Вызван метод {nameof(Read)} класса {nameof(XmlConfigurationReader)}.");
            _printer.Print();
            //логика метода Read
        }
    }
}
