
/** 原価の品目を表すクラス */
public class PrimePriceItem : Item
{
    private String name;
    private int price;
    public PrimePriceItem(String name, int price)
    {
        this.name = name;
        this.price = price;
    }
    public override String getName()
    {
        return this.name;
    }
    public override int getPrice()
    {
        return this.price;
    }
}
