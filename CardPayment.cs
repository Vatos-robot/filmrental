public class CardPaymentStrategy : IPaymentStrategy
{
    public void Pay(double amount)
    {
        // Ici, vous pouvez mettre la logique de paiement par carte de crédit
        Console.WriteLine($"Paiement de {amount}€ effectué avec succès par carte de crédit.");
    }
}

