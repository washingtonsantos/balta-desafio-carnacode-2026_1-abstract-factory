namespace AbstractFactory.Services.Interfaces
{
    public interface IProcessTransaction
    {
        string ProcessTransaction(decimal amount, string cardNumber);
    }
}
