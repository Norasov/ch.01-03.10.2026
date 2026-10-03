public class PaymentTerminal
{
    private double money;

    public double Money
    {
        get { return money; }
    }

    public double EatAffordably(double EatAffordably)
    {
        double b = 2.5;

        if (EatAffordably < b)
        {
            return EatAffordably;
        }

        money += b;
        return EatAffordably - b;
    }

    public double EatHeartily(double EatAffordably)
    {
        double b = 4.3;

        if (EatAffordably < b)
        {
            return EatAffordably;
        }

        money += b;
        return EatAffordably - b;
    }

    public bool EatAffordably(PaymentCard card)
    {
        double b = 2.5;

        if (card.TakeMoney(b))
        {
            money += b;
            return true;
        }

        return false;
    }

    public bool EatHeartily(PaymentCard paymentCard)
    {
        double b = 4.3;

        if (paymentCard.TakeMoney(b))
        {
            money += b;
            return true;
        }

        return false;
    }

    public void AddMoneyToCard(PaymentCard paymentCard, double amount)
    {
        paymentCard.AddMoney(amount);
        money += amount;
    }

}