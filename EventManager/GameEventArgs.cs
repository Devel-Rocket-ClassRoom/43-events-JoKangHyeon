using System;

class GameEventArgs : EventArgs
{
    public string EventName { get; }
    public object Data { get; }

    public GameEventArgs(string eventName, object data)
    {
        EventName = eventName;
        Data = data;
    }
}
