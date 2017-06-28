using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (value.Length < 3 || value == null)
            {
                throw new Exception("Sorry the name length cannot be null or less than 3 symbols");
            }
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            if (value < 0)
            {
                throw new Exception("Sorry peron ages cannot be less than zero!");
            }
            else
            {
                this.age = value;
            }
        }
    }

    public List<BankAccount> Accounts
    {
        get
        {
            return this.accounts;
        }

        set
        {
            this.accounts = new List<BankAccount>();
        }
    }

#pragma warning disable SA1201 // Elements must appear in the correct order
    public Person()
#pragma warning restore SA1201 // Elements must appear in the correct order
    {
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Accounts = this.accounts;
    }

    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.Name = name;
        this.Age = age;
        this.Accounts = accounts;
    }

    public double GetBalance()
    {
        return this.accounts.Sum(x => x.Balance);
    }
}