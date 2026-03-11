using System;

class Timer
{
    int _time = 0;
    public event Action Tick;

    public void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            _time++;
            Console.WriteLine($"타이머: {_time}초");
            Tick?.Invoke();
        }
    }
}
