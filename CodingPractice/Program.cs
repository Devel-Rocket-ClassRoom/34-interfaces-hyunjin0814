using System;
using static System.Net.Mime.MediaTypeNames;

// README.md를 읽고 코드를 작성하세요.
Car car = new Car();
car.Go();

IRepository repository = new Repository();
repository.Get();

Person person = new Person();
person.Work();
person.Rest();

Car2 car1 = new Car2(new GoodBattery());
Car2 car2 = new Car2(new NormalBattery());
car1.Run();
car2.Run();

Dog dog = new Dog();
dog.Eat();
dog.Bark();

Bird bird = new Bird();
bird.Breathe();
bird.Fly();

Pet pet = new Pet();

((IDog2)pet).Eat();
((ICat2)pet).Eat();

IDog2 dog2 = new Pet();
dog2.Eat();

ICat2 cat2 = new Pet();
cat2.Eat();

IExample iex = new Example();
iex.DoWork();

TextEditor textEditor = new TextEditor();
textEditor.Undo();
textEditor.Redo();

Car3 car3 = new Car3();
car3.Run();
car3.Left();
car3.Back();

Player player = new Player();
Enemy enemy = new Enemy();
Building building = new Building();

Attack(player, 20);
Attack(enemy, 30);
Attack(building, 100);

void Attack(IDamageable target, int damage)
{
    target.TakeDamage(damage);
}

Hero hero = new Hero();
Turret turret = new Turret();

hero.Move();
hero.Attack();
turret.Attack();