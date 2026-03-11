using System;

class NotificationService
{
    public NotificationService(ChatRoom room)
    {
        room.MessageReceived += OnMessage;
    }

    public void OnMessage(string sender, string message)
    {
        if (message.Contains("긴급"))
        {
            Console.WriteLine("[알림] 긴급 메시지 수신!");
        }
    }
}