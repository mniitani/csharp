public class PrimePrice : Price
{
    private int value;
    public PrimePrice(int value)
    {
        this.value = value;
    }
    public int getValue()
    {
        return this.value;
    }
}