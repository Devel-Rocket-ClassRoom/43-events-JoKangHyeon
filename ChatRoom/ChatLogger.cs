using System;

class ChatLogger
{
    public ChatLogger(ChatRoom room)
    {
        room.MessageReceived += OnMessage;
    }

    public void OnMessage(string sender, string message)
    {
        Console.WriteLine($"[로그] {sender}: {message}");
    }
}
