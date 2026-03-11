using System;

class Module2
{
    public Module2()
    {
        GlobalNotifier.OnGlobalMessage += OnMessage;
    }

    public void OnMessage(string message)
    {
        Console.WriteLine($"[Module2] 수신: {message}");
    }
}
