public class Market
{
    Utility utility = new();
    Item item = new();
    Inventory inventory = new();
    public List<Item> items = new() {};

    //skapar en lista items

    public void ListItemsMarket(Market market)
    {

        Console.WriteLine("Du är en mästare tjuv, vad vill du sno idag? ");
        Console.WriteLine($"Du har {inventory.InventorySpace} platser i din inventory");
        Console.WriteLine("Dessa föremål finns på markanden, kom ihåg att du har begränsat inventory");
        
        Console.WriteLine("");
        foreach (Item i in market.items) //looks after items
        {
            if (i is VegetableItem)
            {
                Console.Write(((VegetableItem)i).Vegetables);
            }
            if (i is SmellyItem)
            {
                if (((SmellyItem)i).IsBig) //if isBig true print big
                {
                    Console.Write("Big ");
                }
                else if (!((SmellyItem)i).IsBig) //look if isBig false, if it is then print little
                {
                    Console.Write("Small ");
                }
                
            }
            Console.WriteLine(i.Name + "(" + i.Space + ")" + ", ");

        }
        Console.WriteLine("");
    }
    //prints out all of the items on the market. Also it prints out its smell and size

    public void MarketBeginGame(Market market)
    {
        market.items.Clear();

        
        market.items.Add(item);

        for (int i = 0; i < 6; i++)
        {
            VegetableItem item = new();
            items.Add(item);
            //Adds all the items that are vegetables
        }
        //Add them in the item list
        for (int i = 0; i < 6; i++)
        {
            SmellyItem VegetableItem = new();
            items.Add(VegetableItem);
        }
        //Create and add vegetables in items list
    }
    public int SelectItem(int MarketItemsCount)//Gets an answer in a number
    {
        Console.WriteLine("");
        Console.WriteLine("Skriv nummer mellan 1 och " + MarketItemsCount); //print
        while (true)
        {
            int _validNumber = utility.GetNumber();
            if (_validNumber > 0 && _validNumber <= MarketItemsCount)
            {

                return _validNumber;
            }
            //check so the number is in the accurate length in marketitemscount.

            else
            {
                Console.WriteLine("SKRIV ETT NUMMER MELLAN 1-" + MarketItemsCount + "!!!!"); //instructions for the user that they put out a invalid input.
            }
            //If it is a invalid input it says so.
        }
    }
    //After it gets an input it returns an answer on which item the player have chosen.

}