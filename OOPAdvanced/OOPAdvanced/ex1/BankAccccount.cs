using System;
using System.Collections.Generic;

public class BankAccount
{
    private int accountNumber;
    private string accountHolder;
    private decimal balance;
    private List<Transaction> transactions;

    public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
    public string AccountHolder { get { return accountHolder; } set { accountHolder = value; } }

    public BankAccount(int accountNumber, string accountHolder, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
        this.transactions = new List<Transaction>();
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        transactions.Add(new Transaction("deposit", amount));
    }

    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            transactions.Add(new Transaction("withdraw", amount));
        }
        else
        {
            throw new Exception("You do not have enough money in your account.");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }

    private int SortTransaction(Transaction a, Transaction b)
    {
        return a.Timestamp.CompareTo(b.Timestamp);
    }

    public List<Transaction> GetTransactionHistory()
    {
        List<Transaction> list = new List<Transaction>(transactions);
        list.Sort(SortTransaction);
        return list;
    }
}