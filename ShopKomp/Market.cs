public class Market
{
    Utility function = new();
    Item item = new();
    public List<Item> items = new() {};

    //skapar en lista items

    public void ListItemsMarket(Market market)
    {
        Console.WriteLine("");
        Console.WriteLine("På marken finns det ");
        Console.WriteLine("");
        foreach (Item i in market.items)
        {
            if (i is VegetableItem)
            {
                Console.Write(((VegetableItem)i).Vegetables);
            }
            if (i is SmellyItem)
            {
                if (((SmellyItem)i).IsBig)
                {
                    Console.Write("Big ");
                }
                Console.Write(((SmellyItem)i).IsBig);
            }
            Console.WriteLine(i.Name + "(" + i.Space + ")" + ", ");

        }
        Console.WriteLine("");
    }
    //void för att skriva ut alla items i ground som skriver även ut weight och Length om de har det

    public void MarketBeginGame(Market market)
    {
        market.items.Clear();

        
        market.items.Add(item);

        for (int i = 0; i < 6; i++)
        {
            VegetableItem item = new();
            items.Add(item);
            //sätter ut heavy på alla items som kan vara heavy
        }
        //skapar items och sätter de i listan items
        for (int i = 0; i < 6; i++)
        {
            SmellyItem weapon = new();
            items.Add(weapon);
        }
        //skapar weapon items i listan items
    }
    public int ItemAnswer(int MarketItemsCount)
    {
        Console.WriteLine("");
        Console.WriteLine("Skriv ett nummer mellan 1-" + MarketItemsCount);
        while (true)
        {
            int j = function.GetNummber();//tryparse
            if (j > 0 && j <= MarketItemsCount)
            {

                return j;
            }
            //kollar att numret är inom det angivna intervalet

            else
            {
                Console.WriteLine("SKRIV ETT NUMMER MELLAN 1-" + MarketItemsCount + "!!!!");
            }
            //ger instruktioner ifall fel input
        }
    }
    //får ett answer och retunerar en int

}