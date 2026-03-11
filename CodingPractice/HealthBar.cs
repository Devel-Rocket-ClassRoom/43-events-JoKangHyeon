using System;

class HealthBar
{
    public void OnPlayerDamaged(int health)
    {
        Console.WriteLine($"[UI] 체력바 업데이트: {health}%");
    }
}
