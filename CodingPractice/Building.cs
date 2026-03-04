using System;

class Building : IDamageable
{
    public int Health { get; private set; } = 500;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"건물이 {damage} 대미지를 받음. 남은 내구도: {Health}");
    }
}