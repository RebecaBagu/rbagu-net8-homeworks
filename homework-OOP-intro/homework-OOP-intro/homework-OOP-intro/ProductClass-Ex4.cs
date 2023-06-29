using System;
public class Product
{
    string name;
    double price;
    int quantity;
    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }
    public string GetName()
    {
        return this.name;
    }
    public double GetPrice()
    {
        return this.price;
    }
    public int GetQuantity()
    {
        return this.quantity;
    }
    public void SetName(string NewName)
    {
        this.name = NewName;
    }
    public void SetPrice(double NewPrice)
    {
        this.price = NewPrice;
    }
    public void SetQuantity(int NewQuantity)
    {
        this.quantity = NewQuantity;
    }
}