using System.Diagnostics;

public abstract class MarginPrice : Price
{
    protected Price originalPrice;
    protected MarginPrice(Price price){
        this.originalPrice = price;
    }

/*    public virtual int getValue()
    {
        throw new NotImplementedException();
    }*/

    public abstract int getValue();
}
