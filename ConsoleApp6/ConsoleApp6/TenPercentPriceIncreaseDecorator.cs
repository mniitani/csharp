
/** 10%値上げするクラス */
public class TenPercentPriceIncreaseDecorator : Decorator
{
    public TenPercentPriceIncreaseDecorator(Item item) : base(item)
    {
    }
    public override String getName()
    {
        return base.originalItem.getName() + "(" + base.originalItem.getPrice() + "→" + this.getPrice() + "円に改定)";
    }
    public override int getPrice()
    {
        return (int)(base.originalItem.getPrice() * 1.1f);
    }
}
