using DependencyInjectionSampeApp.Interfaces;
using System;

namespace DependencyInjectionSampeApp.Implementations
{
    class JsonConfigurationReader : IConfigurationReader
    {
        private readonly IPrinter _printer;
        private readonly ILogger _logger;

        public JsonConfigurationReader(IPrinter printer, ILogger logger)
        {
            _printer = printer ?? throw new ArgumentNullException(nameof(printer));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void Read()
        {
            Console.WriteLine($"Вызван метод {nameof(Read)} класса {nameof(JsonConfigurationReader)}.");
            _printer.Print();
            _logger.Log();
            //логика метода Read
        }
    }
}
