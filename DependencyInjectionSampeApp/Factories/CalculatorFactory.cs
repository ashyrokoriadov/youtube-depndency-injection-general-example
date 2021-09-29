using DependencyInjectionSampeApp.Implementations;
using DependencyInjectionSampeApp.Interfaces;

namespace DependencyInjectionSampeApp.Factories
{
    class CalculatorFactory : ICalculatorFactory
    {
        public ICalculator Order()
        {
            var printer = new Printer();
            var logger = new Logger();
            var configReader = new XmlConfigurationReader(printer);
            var connector = new DatabaseConnector(logger, configReader);
            var calculator = new Calculator(printer, connector);
            return calculator;
        }
    }
}
