namespace BankingDomain;

public class BankAccount
{
    private decimal _balance = 5000M;

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        _balance -= amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}