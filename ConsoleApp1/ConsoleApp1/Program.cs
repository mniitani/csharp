using ConsoleApp1;

class Test
{
    static void Main(string[] args)
    {
        Fruit? fruit = null;
        if (args != null && args.Length > 0)
        {
            switch (args[0])
            {
                case ("apple"):
                    fruit = new Apple();
                    break;
                case ("cherry"):
                    fruit = new Cherry();
                    break; 
            }
            if(fruit!=null) fruit.eat();
        }
    }

}