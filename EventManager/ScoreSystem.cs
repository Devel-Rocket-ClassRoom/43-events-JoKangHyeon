using System;

class ScoreSystem
{
    public ScoreSystem()
    {
        EventManager.OnGameEvent += OnGameEvent;
    }

    public void OnGameEvent(object sender, GameEventArgs e)
    {
        if (e.EventName is "ScoreChanged")
        {
            Console.WriteLine($"점수 변경: {e.Data}점");
        }
    }
}
