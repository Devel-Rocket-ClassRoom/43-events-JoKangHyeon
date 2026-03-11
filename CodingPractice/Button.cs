class Button
{
    public event EventHandler Click;

    public void OnClick()
    {
        Click?.Invoke();
    }
}
