using System;

// README.md를 읽고 코드를 작성하세요.
Character hero = new Character("용사", 100, 20);
Monster slime = new Monster("슬라임", 30, 5);
Monster goblin = new Monster("고블린", 50, 10);

Console.WriteLine("=== 전투 시작 ===");
Console.WriteLine();
ProcessBattle(hero, slime);
ProcessBattle(slime, hero);
ProcessBattle(hero, slime);
Console.WriteLine();

Console.WriteLine("=== 고블린 등장 ===");
Console.WriteLine();
ProcessBattle(hero, goblin);
ProcessBattle(goblin, hero);
ProcessBattle(hero, goblin);
ProcessBattle(hero, goblin);

void ProcessBattle(IAttacker attacker, IDefender defender)
{
    attacker.Attack(defender);
}