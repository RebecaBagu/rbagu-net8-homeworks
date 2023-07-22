using System;
public class Transaction
{
    public Transaction(string type, decimal amount)
    {
        
        Type = type;
        Amount = amount;
    }
    public DateTime Timestamp { get; set; }
    public string Type { get; set; }
    public decimal Amount { get; set; }
}