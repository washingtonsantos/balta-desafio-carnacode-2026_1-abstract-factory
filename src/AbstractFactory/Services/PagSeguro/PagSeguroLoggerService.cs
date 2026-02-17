using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguro
{
    public class PagSeguroLoggerService(PagSeguroClient client) : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
        }
    }
}
