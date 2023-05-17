public abstract class Item
{
    public abstract String getName();
    public abstract int getPrice();
    public void printInfo()
    {
        Console.WriteLine(getName() + ":" + getPrice() + "円");
    }
}
