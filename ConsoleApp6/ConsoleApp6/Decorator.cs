
/** Decoratorクラス */
public abstract class Decorator : Item
{
    protected Item originalItem;
    protected Decorator(Item item)
    {
        this.originalItem = item;
    }
}
