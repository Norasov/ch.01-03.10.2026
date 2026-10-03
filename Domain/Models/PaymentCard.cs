public class PaymentCard
{
    public double Balance { get; set; }

    public PaymentCard(double balance)
    {
        Balance = balance;
    }

    public void AddMoney(double amount)
    {
        Balance += amount;
    }

    public bool TakeMoney(double amount)
    {
        if (amount > Balance || amount < 0)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }
}