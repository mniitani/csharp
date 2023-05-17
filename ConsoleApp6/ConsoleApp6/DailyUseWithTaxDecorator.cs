
/** 日用品に消費税を付与するクラス */
public class DailyUseWithTaxDecorator : Decorator
{
    public DailyUseWithTaxDecorator(Item item) : base(item)
    {
    }
    public override String getName()
    {
        return base.originalItem.getName() + "(税込)";
    }
    public override int getPrice()
    {
        if (base.originalItem is DailyUseWithTaxDecorator)
        {
            throw new NotSupportedException("多重課税です");
        }
        return (int)(base.originalItem.getPrice() * 1.1f);
    }
}
