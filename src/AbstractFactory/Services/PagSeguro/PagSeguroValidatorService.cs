using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguro
{
    public sealed class PagSeguroValidatorService(PagSeguroClient client) : IValidatorService
    {
        public bool ValidateCard(string cardNumber)
        {
            Console.WriteLine("PagSeguro: Validando cartão...");
            return cardNumber.Length == 16;
        }
    }
}
