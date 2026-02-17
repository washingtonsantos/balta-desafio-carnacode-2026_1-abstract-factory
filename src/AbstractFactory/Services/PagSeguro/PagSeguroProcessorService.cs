using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguro
{
    public class PagSeguroProcessorService(PagSeguroClient client) : IProcessTransaction
    {
        public string ProcessTransaction(decimal amount, string cardNumber)
        {
            Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
            return $"PAGSEG-{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}
