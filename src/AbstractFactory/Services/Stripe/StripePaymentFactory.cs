using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Stripe
{
    public sealed class StripePaymentFactory(StripeClient client) : IPaymentProviderFactory
    {
        public IValidatorService CreateValidator() =>
            new StripeValidatorService(client);

        public IProcessTransaction CreateProcessor() =>
             new StripeProcessorService(client);

        public ILoggerService CreateLogger() =>
            new StripeLoggerService(client);
    }
}
