using AbstractFactory.Services;

Console.WriteLine("=== Sistema de Pagamentos ===\n");

var factory = PaymentService.BuildFactory(provider: "pagseguro");
var paymentService = new PaymentService(factory);

if (paymentService.ValidateCard("1234567890123456"))
{
    paymentService.ProcessTransaction(150.00m, "1234567890123456");
    paymentService.Log($"Transação processada: {150.00m} para o cartão {1234567890123456}");
}
else
{
    Console.WriteLine("Cartão inválido.");
}

Console.WriteLine();

factory = PaymentService.BuildFactory(provider: "mercadopago");
paymentService = new PaymentService(factory);

if (paymentService.ValidateCard("5234567890123456"))
{
    paymentService.ProcessTransaction(200.00m, "5234567890123456");
    paymentService.Log($"Transação processada: {200.00m} para o cartão {5234567890123456}");
}
else
{
    Console.WriteLine("Cartão inválido.");
}

Console.WriteLine();

factory = PaymentService.BuildFactory(provider: "stripe");
paymentService = new PaymentService(factory);

if (paymentService.ValidateCard("4206822971352936"))
{
    paymentService.ProcessTransaction(450.00m, "4206822971352936");
    paymentService.Log($"Transação processada: {450.00m} para o cartão {4206822971352936}");
}
else
{
    Console.WriteLine("Cartão inválido.");
}

Console.WriteLine();