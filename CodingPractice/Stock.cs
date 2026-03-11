using System;

class Stock
{
    int price = 100;
    string name;

    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    public Stock(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

    public void ChangePrice(int newPrice)
    {
        PriceChangedEventArgs args = new PriceChangedEventArgs(price, newPrice);
        price = newPrice;


        PriceChanged?.Invoke(this, args);
    }

    public override string ToString()
    {
        return name;
    }
}
