using AbstractFactory.Services.MercadoPago;
using AbstractFactory.Services.PagSeguro;
using AbstractFactory.Services.Stripe;

namespace AbstractFactory.Services
{
    public class PaymentService
    {
        private readonly IPaymentProviderFactory _factory;

        public PaymentService(IPaymentProviderFactory factory) =>
            _factory = factory;

        public static IPaymentProviderFactory BuildFactory(string provider)
        {
            return provider switch
            {
                "stripe" => new StripePaymentFactory(new StripeClient()),
                "pagseguro" => new PagSeguroPaymentFactory(new PagSeguroClient()),
                "mercadopago" => new MercadoPagoPaymentFactory(new MercadoPagoClient()),
                _ => throw new NotSupportedException($"Provider inválido: {provider}")
            };
        }

        public bool ValidateCard(string cardNumber) =>
                _factory.CreateValidator().ValidateCard(cardNumber);

        public string ProcessTransaction(decimal amount, string cardNumber) =>
            _factory.CreateProcessor().ProcessTransaction(amount, cardNumber);

        public void Log(string message) =>
            _factory.CreateLogger().Log(message);
    }
}
