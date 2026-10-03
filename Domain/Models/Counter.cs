public class Counter
{
    public int Value { get; set; }

    public Counter(int startValue)
    {
        Value = startValue;
    }

    public Counter()
    {
        Value = 0;
    }

    public void Increase()
    {
        Value++;
    }

    public void Decrease()
    {
        Value--;
    }

    public void Increase(int increaseBy)
    {
        if (increaseBy >= 0)
        {
            Value += increaseBy;
        }
    }

    public void Decrease(int decreaseBy)
    {
        if (decreaseBy >= 0)
        {
            Value -= decreaseBy;
        }
    }

}