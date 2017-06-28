using System;
using System.Collections.Generic;

public class Program
{
    public const string AlreadyExistingAccount = "Account already exists";
    public const string NotExistingAccount = "Account does not exist";

    public static void Main()
    {
        string input;

        var listOfBankAccounts = new Dictionary<int, BankAccount>();
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input
                .Split();
            var command = tokens[0];

            switch (command)
            {
                case "Create":
                    Create(listOfBankAccounts, tokens);
                    break;
                case "Deposit":
                    Deposit(listOfBankAccounts, tokens);
                    break;
                case "Withdraw":
                    Withdraw(listOfBankAccounts, tokens);
                    break;
                case "Print":
                    Print(listOfBankAccounts, tokens);
                    break;
                default:
                    break;
            }
        }
    }

    private static void Print(Dictionary<int, BankAccount> listOfBankAccounts, string[] tokens)
    {
        var accountID = int.Parse(tokens[1]);

        if (listOfBankAccounts.ContainsKey(accountID))
        {
            listOfBankAccounts[accountID].Print(accountID);
        }
        else
        {
            Console.WriteLine(NotExistingAccount);
        }
    }

    private static void Withdraw(Dictionary<int, BankAccount> listOfBankAccounts, string[] tokens)
    {
        var accountId = int.Parse(tokens[1]);
        var amount = double.Parse(tokens[2]);

        if (listOfBankAccounts.ContainsKey(accountId))
        {
            listOfBankAccounts[accountId].Withdraw(amount);
        }
        else
        {
            Console.WriteLine(NotExistingAccount);
        }
    }

    private static void Deposit(Dictionary<int, BankAccount> listOfBankAccounts, string[] tokens)
    {
        var accountId = int.Parse(tokens[1]);
        var amount = double.Parse(tokens[2]);
        if (listOfBankAccounts.ContainsKey(accountId))
        {
            listOfBankAccounts[accountId].Deposit(amount);
        }
        else
        {
            Console.WriteLine(NotExistingAccount);
        }
    }

    private static void Create(Dictionary<int, BankAccount> listOfBankAccounts, string[] tokens)
    {
        var command = tokens[0];
        var id = int.Parse(tokens[1]);
        var account = new BankAccount();
        if (!listOfBankAccounts.ContainsKey(id))
        {
            account.ID = id;
            listOfBankAccounts.Add(id, account);
        }
        else
        {
            Console.WriteLine(AlreadyExistingAccount);
        }
    }
}