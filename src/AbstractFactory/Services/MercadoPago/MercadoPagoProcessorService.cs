using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.MercadoPago
{
    public class MercadoPagoProcessorService(MercadoPagoClient client) : IProcessTransaction
    {
        public string ProcessTransaction(decimal amount, string cardNumber)
        {
            Console.WriteLine($"MercadoPago: Processando R$ {amount}...");
            return $"MP-{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}