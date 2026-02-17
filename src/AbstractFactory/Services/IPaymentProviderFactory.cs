using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services
{
    public interface IPaymentProviderFactory
    {
        IValidatorService CreateValidator();
        IProcessTransaction CreateProcessor();
        ILoggerService CreateLogger();
    }
}
