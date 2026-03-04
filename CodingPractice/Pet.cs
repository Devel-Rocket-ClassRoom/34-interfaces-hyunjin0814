using System;

class Pet : IDog2, ICat2
{
    void IDog2.Eat()
    {
        Console.WriteLine("개처럼 먹습니다.");
    }
    void ICat2.Eat()
    {
        Console.WriteLine("고양이처럼 먹습니다.");
    }
}
