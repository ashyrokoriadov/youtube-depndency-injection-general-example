using DependencyInjectionSampeApp.Implementations;
using DependencyInjectionSampeApp.Interfaces;

namespace DependencyInjectionSampeApp.Factories
{
    class CalculatorFactoryWithJsonConfigReader : ICalculatorFactory
    {
        public ICalculator Order()
        {
            var printer = new Printer();
            var logger = new Logger();
            var configReader = new JsonConfigurationReader(printer, logger);
            var connector = new DatabaseConnector(logger, configReader);
            var calculator = new Calculator(printer, connector);
            return calculator;
        }
    }
}