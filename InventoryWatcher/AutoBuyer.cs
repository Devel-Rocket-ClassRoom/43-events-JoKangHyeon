using System;

class AutoBuyer
{
    public void Subscribe(Inventory inventory)
    {
        inventory.ItemChanged += OnItemChanged;
    }

    public void Unsubscribe(Inventory inventory)
    {
        inventory.ItemChanged -= OnItemChanged;
    }

    public void OnItemChanged(string name, int oldCount, int newCount)
    {
        if (newCount == 0)
            Console.WriteLine($"[자동구매] {name} 재고 소진! 자동 구매 요청");
    }
}