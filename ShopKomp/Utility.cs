public class Utility
{
    public int GetNummber()
    {
        string? i = "";

        int j;
        while (!int.TryParse(i, out j) == true) //tryparse
        {
            i = Console.ReadLine();
            if (!int.TryParse(i, out j) == true)
            {
                Console.WriteLine("DU MÅSTE SKRIVA ETT NUMMERRRRRRRRR");

            }
            //kollar att det är ett nummer, om inte ger användaren instruktioner att det är fel
        }
        //kör loopen tills användaren har skrivit ett nummer, sammt gör en try parse med answer och kollar att det går
        return j;
        //retunerar numret som j
    }
    //kollar så att det är ett nummer och inte text

    public bool YesOrNo()
    {
        string? i = Console.ReadLine();
        if (i.ToUpper() == "Y")
        {
            Console.Clear();
            return true;
        }
        else//annars returnera false och avsluta spelet
        {
            return false;
        }

    }

    public bool RestartGame(Inventory inventory, Market market, bool Game)
    {
        ResetGame(inventory, market);
        Game = true;
        return Game;
    }
    //funktion för att spelaren ska kunna köra igen, kollar input Y/N
    
    public void ResetGame(Inventory inventory, Market market)
    {
        inventory.ResetGameInventory(inventory);
        market.MarketBeginGame(market);
    }
}

