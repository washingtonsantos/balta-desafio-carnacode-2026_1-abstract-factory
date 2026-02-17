using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.MercadoPago
{
    public sealed class MercadoPagoPaymentFactory(MercadoPagoClient client) : IPaymentProviderFactory
    {
        public IValidatorService CreateValidator() =>
            new MercadoPagoValidatorService(client);

        public IProcessTransaction CreateProcessor() =>
             new MercadoPagoProcessorService(client);

        public ILoggerService CreateLogger() =>
            new MercadoPagoLoggerService(client);
    }
}