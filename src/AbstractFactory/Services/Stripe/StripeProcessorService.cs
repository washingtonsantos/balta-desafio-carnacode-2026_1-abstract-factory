using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Stripe
{
    public class StripeProcessorService(StripeClient client) : IProcessTransaction
    {
        public string ProcessTransaction(decimal amount, string cardNumber)
        {
            Console.WriteLine($"Stripe: Processando ${amount}...");
            return $"STRIPE-{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}
