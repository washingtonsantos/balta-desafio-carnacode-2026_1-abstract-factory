using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Stripe
{
    public class StripeLoggerService(StripeClient client) : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
        }
    }
}
