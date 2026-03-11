using System;

class Car
{
    public event EventHandler<FuelEventArgs> FuelLow;
    public event Action<int> FuelChanged;

    int _fuel;

    public Car(int fuel)
    {
        _fuel = fuel;
    }

    public void Drive()
    {
        if (_fuel <= 0)
        {
            Console.WriteLine("연료 없음! 운전 불가");
            return;
        }

        _fuel -= 10;

        Console.WriteLine($"운전 중... 연료: {_fuel}%");

        FuelChanged?.Invoke(_fuel);

        if (_fuel <= 0)
        {
            FuelLow?.Invoke(this, new FuelEventArgs("연료가 부족합니다", _fuel));
        }
        else if (_fuel <= 20)
        {
            FuelLow?.Invoke(this, new FuelEventArgs("연료가 바닥났습니다!", _fuel));
        }
    }
}
