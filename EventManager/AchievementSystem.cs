using System;

class AchievementSystem
{
    public AchievementSystem()
    {
        EventManager.OnGameEvent += OnGameEvent;
    }

    public void OnGameEvent(object sender, GameEventArgs e)
    {
        if (e.EventName is "Achievement")
        {
            Console.WriteLine($"업적 달성: {e.Data}");
        }
    }
}
