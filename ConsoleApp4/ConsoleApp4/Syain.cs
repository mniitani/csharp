class Syain
{
    ISyain syain;

    // Constructor
    public Syain(ISyain syain)
    {
        this.syain = syain;
    }

    public void standup()
    {
        this.syain.standup();
    }
    public void switchSyain(ISyain syain)
    {
        this.syain = syain;
    }
}