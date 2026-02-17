using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.MercadoPago
{
    public class MercadoPagoLoggerService(MercadoPagoClient client) : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
        }
    }
}