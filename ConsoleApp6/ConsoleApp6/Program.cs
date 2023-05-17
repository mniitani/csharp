using System.Diagnostics;
using System.Xml.Linq;

public class DecoratorTest
{
    public static void Main(String[] argv)
    {
        Item soap = new PrimePriceItem("石鹸", 100);
        Item banana = new PrimePriceItem("バナナ", 100);

        soap.printInfo();
        banana.printInfo();

        new DailyUseWithTaxDecorator(soap).printInfo();
        new FoodWithTaxDecorator(banana).printInfo();

        new TenPercentPriceIncreaseDecorator(soap).printInfo();
        new TenPercentPriceIncreaseDecorator(banana).printInfo();
        
        new DailyUseWithTaxDecorator(new TenPercentPriceIncreaseDecorator(soap)).printInfo();
        new FoodWithTaxDecorator(new TenPercentPriceIncreaseDecorator(banana)).printInfo();
        
        new DailyUseWithTaxDecorator(new TenPercentPriceIncreaseDecorator(new TenPercentPriceIncreaseDecorator(soap))).printInfo();
        new FoodWithTaxDecorator(new TenPercentPriceIncreaseDecorator(new TenPercentPriceIncreaseDecorator(banana))).printInfo();

        new DailyUseWithTaxDecorator(new DailyUseWithTaxDecorator(new TenPercentPriceIncreaseDecorator(soap))).printInfo();

    }
}