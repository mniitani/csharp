using ConsoleApp3;
using System;

class Syain
{
    SyainAction action;

    // Constructor
    public Syain(SyainAction action)
    {
        this.action = action;
    }

    public void standup()
    {
        this.action();
    }
}

namespace ConsoleApp3
{
    public delegate void SyainAction();
}