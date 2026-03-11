using System;

class SecurePublisher
{

    private EventHandler _event;
    private readonly object _lock = new object();

    public event EventHandler Event
    {
        add
        {
            lock (_lock)
            {
                Console.WriteLine($"구독자 추가: {value.Method.Name}");
                _event += value;
            }
        }
        remove
        {
            lock (_lock)
            {
                Console.WriteLine($"구독자 제거: {value.Method.Name}");
                _event -= value;
            }
        }
    }

    public void RaiseEvent()
    {
        Console.WriteLine("이벤트 발생:");
        _event?.Invoke();
    }
}
