using System;

class Module1
{
    public Module1()
    {
        GlobalNotifier.OnGlobalMessage += OnMessage;
    }

    public void OnMessage(string message)
    {
        Console.WriteLine($"[Module1] 수신: {message}");
    }
}
