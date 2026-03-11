using System;

class SoundSystem
{
    public SoundSystem()
    {
        EventManager.OnGameEvent += OnGameEvent;
    }

    public void OnGameEvent(object sender, GameEventArgs e)
    {
        Console.WriteLine($"[Sound] 이벤트: {e.EventName}");
    }
}