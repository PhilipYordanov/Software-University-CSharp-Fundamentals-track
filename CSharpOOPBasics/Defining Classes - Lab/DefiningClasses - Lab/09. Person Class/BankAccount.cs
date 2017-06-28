using System;

public class BankAccount
{
    private int id;
    private double balance;

    public int ID
    {
        get
        {
            return this.id;
        }

        set
        {
            this.id = value;
        }
    }

    public double Balance
    {
        get
        {
            return this.balance;
        }

        set
        {
            this.balance = value;
        }
    }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (this.balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            this.balance -= amount;
        }
    }

    public void Print(int id)
    {
        Console.WriteLine($"Account ID{this.ID}, balance {this.balance:F2}");
    }

    public override string ToString()
    {
        return $"Account {this.ID}, balance {this.balance}";
    }
}