using System;

class InventoryUI
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
        Console.WriteLine($"[UI] {name}: {oldCount} → {newCount}");
    }
}
