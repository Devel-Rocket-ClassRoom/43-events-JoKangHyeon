using System;

class Player
{
    int _health = 100;
    public event Action<int> DamageTanken;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"플레이어 체력: {_health}");
        DamageTanken?.Invoke(_health);
    }
}
