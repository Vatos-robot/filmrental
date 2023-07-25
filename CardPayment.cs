public class CardPaymentStrategy : IPaymentStrategy
{
    public void Pay(double amount)
    {
        
        Console.WriteLine($"Paiement de {amount}€ effectué avec succès par carte de crédit.");
    }
}

