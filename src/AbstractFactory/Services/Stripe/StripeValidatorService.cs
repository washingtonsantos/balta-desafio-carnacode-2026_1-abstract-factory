using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Stripe
{
    public sealed class StripeValidatorService(StripeClient client) : IValidatorService
    {
        public bool ValidateCard(string cardNumber)
        {
            Console.WriteLine("Stripe: Validando cartão...");
            return cardNumber.Length == 16 && cardNumber.StartsWith("4");
        }
    }
}
