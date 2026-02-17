using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.MercadoPago
{
    public class MercadoPagoValidatorService(MercadoPagoClient client) : IValidatorService
    {
        public bool ValidateCard(string cardNumber)
        {
            Console.WriteLine("MercadoPago: Validando cartão...");
            return cardNumber.Length == 16 && cardNumber.StartsWith("5");
        }
    }
}
