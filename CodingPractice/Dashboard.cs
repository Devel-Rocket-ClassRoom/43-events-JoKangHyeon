using System;

class Dashboard
{
    public void Subscribe(Car c)
    {
        c.FuelChanged += OnFuelChanged;
        c.FuelLow += OnFuelLow;
    }

    public void Unsubscribe(Car c)
    {
        c.FuelChanged -= OnFuelChanged;
        c.FuelLow -= OnFuelLow;
    }

    public void OnFuelChanged(int fuel)
    {
        Console.Write("[대시보드] 연료 게이지: ");
        Console.WriteLine(new string('█', fuel / 10));
    }

    public void OnFuelLow(object sender, FuelEventArgs e)
    {
        Console.WriteLine($"[경고!] {e.Message} (잔량: {e.Fuel}%)");
    }
}
