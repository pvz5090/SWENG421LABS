using System;

namespace p2;

public class Desk : Product
{
    public Desk(int id, string name, double price):base(id, name, price) {}

    public override string getName()
    {
        return this.getName + "Desk";
    }
}
