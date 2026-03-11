using System;

class FuelEventArgs : EventArgs
{
    public string Message { get; }
    public int Fuel { get; }

    public FuelEventArgs(string message, int fuel)
    {
        Message = message;
        Fuel = fuel;
    }
}
