using System;

class GameCharacter
{
    int _health = 100;

    public event Action OnDeath;
    public event Action<int> OnDamaged;
    public event Action<int, string> OnAttack;

    public void Attack(int damage, string target)
    {
        OnAttack?.Invoke(damage, target);
    }

    public void TakeDamage(int amount)
    {
        _health -= amount;
        OnDamaged?.Invoke(_health);

        if (_health <= 0)
        {
            OnDeath?.Invoke();
        }
    }
}
