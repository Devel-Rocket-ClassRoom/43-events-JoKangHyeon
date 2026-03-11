using System;

class PriceChangedEventArgs : EventArgs
{
    public int OldPrice { get; }
    public int NewPrice { get; }
    public double ChangePercent { get; }

    public PriceChangedEventArgs(int oldPrice, int newPrice)
    {
        OldPrice = oldPrice;
        NewPrice = newPrice;
        if (oldPrice != 0)
        {
            ChangePercent = (newPrice - oldPrice) / (double)oldPrice * 100;
        }
    }
}
