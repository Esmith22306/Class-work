public class Loanable
{
    protected bool _isCheckedIn = true;

    public void Checkout()
    {
        _isCheckedIn = false;
    }

    public void CheckIn()
    {
        _isCheckedIn = true;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Available: {_isCheckedIn}");
    }
}
