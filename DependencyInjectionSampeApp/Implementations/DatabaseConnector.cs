using DependencyInjectionSampeApp.Interfaces;
using System;

namespace DependencyInjectionSampeApp.Implementations
{
    class DatabaseConnector : IConnector
    {
        private readonly ILogger _logger;
        private readonly IConfigurationReader _configReader;

        public DatabaseConnector(ILogger logger, IConfigurationReader configReader)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _configReader = configReader ?? throw new ArgumentNullException(nameof(configReader));
        }

        public void Connect()
        {
            Console.WriteLine($"Вызван метод {nameof(Connect)} класса {nameof(DatabaseConnector)}.");
            _configReader.Read();
            _logger.Log();
            //логика метода Connect
        }
    }
}
