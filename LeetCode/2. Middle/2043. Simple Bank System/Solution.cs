namespace LeetCode._2._Middle._2043._Simple_Bank_System;

public class Bank
{
    private readonly long[] balance;

    public Bank(long[] balance)
    {
        this.balance = balance;
    }

    public bool Transfer(int account1, int account2, long money)
    {
        var valid = IsValidAccount(account1) && IsValidAccount(account2) && balance[account1 - 1] >= money;
        if (valid)
        {
            balance[account1 - 1] -= money;
            balance[account2 - 1] += money;
        }

        return valid;
    }

    public bool Deposit(int account, long money)
    {
        var valid = IsValidAccount(account);
        if (valid)
            balance[account - 1] += money;
        return valid;
    }

    public bool Withdraw(int account, long money)
    {
        var valid = IsValidAccount(account) && balance[account - 1] >= money;
        if (valid)
            balance[account - 1] -= money;
        return valid;
    }

    private bool IsValidAccount(int account) =>
        account > 0 && account <= balance.Length;
}