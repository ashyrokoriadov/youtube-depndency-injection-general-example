using DependencyInjectionSampeApp.Interfaces;

namespace DependencyInjectionSampeApp.Factories
{
    interface ICalculatorFactory
    {
        ICalculator Order();
    }
}
