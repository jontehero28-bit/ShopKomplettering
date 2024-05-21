

public class Market
{
    public List<Item> items = new() {}; //skapar listan för items
    
    public void ListStealItemMarket(Market market)
    {
        Console.WriteLine("Du är en tjuv som snattar grejer och säljer de i shopen.");
        Console.WriteLine("Vad vill du försöka sno?");
        Console.WriteLine("");
    }
}