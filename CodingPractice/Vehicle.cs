using System;
using System.ComponentModel;

abstract class Vehicle
{
    public abstract void Back();

    public void Left()
    {
        Console.WriteLine("좌회전");
    }
}
