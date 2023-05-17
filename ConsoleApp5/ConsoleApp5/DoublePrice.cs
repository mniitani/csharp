public class DoublePrice : MarginPrice
{

    public DoublePrice(Price price) : base(price)
    {        
    }
    public override int getValue()
    {
        return base.originalPrice.getValue() * 2;
    }
}
