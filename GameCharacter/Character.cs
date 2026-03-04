using System;

class Character : IAttacker, IDefender
{
    private int _currentHp;

    public string Name { get; private set; }
    public int MaxHp { get; private set; }
    public int AttackPower { get; private set; }
    public int CurrentHp 
    {   get => _currentHp;
        private set
        {
            _currentHp = Math.Clamp(value, 0, MaxHp);
        }
    }
    public bool IsDead { get; private set; }

    public Character(string name, int maxHp, int attackPower)
    {
        Name = name;
        MaxHp = maxHp;
        CurrentHp = MaxHp;
        AttackPower = attackPower;
        IsDead = false;
    }

    public void Attack(IDefender target)
    {
        Console.Write($"{Name}(이/가) {target}에게 {AttackPower} 대미지!");
        target.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage)
    {
        CurrentHp -= damage;
        Console.WriteLine($"{Name} HP: {CurrentHp}/{MaxHp}");
    }

    public override string ToString()
    {
        return Name;
    }
}
