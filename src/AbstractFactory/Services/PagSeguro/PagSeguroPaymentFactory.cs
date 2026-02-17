using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguro
{
    public sealed class PagSeguroPaymentFactory(PagSeguroClient client) : IPaymentProviderFactory
    {
        public IValidatorService CreateValidator() =>
            new PagSeguroValidatorService(client);

        public IProcessTransaction CreateProcessor() =>
             new PagSeguroProcessorService(client);

        public ILoggerService CreateLogger() =>
            new PagSeguroLoggerService(client);
    }
}
