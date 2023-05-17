public class WholesalePrice : MarginPrice
{
    private int advantage;
    public WholesalePrice(Price price, int advantage) : base(price)
    {
        this.advantage = advantage;
    }
    public override int getValue()
    {
        return base.originalPrice.getValue() + advantage;
    }
}