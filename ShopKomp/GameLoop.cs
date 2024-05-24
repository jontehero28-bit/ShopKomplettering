public class GameLoop
{
    Utility utility = new(); // think of it as a collection of functions
    Market market = new();  //market
    Inventory inventory = new();  //inventory system
    // Utility, Market, and Inventory classes are created.

    public void Run()
    {
        bool GameOn = false; // variable for game state

        while (true)
        {
            // method for starting the game and then restarting it when it is over.
            GameOn = utility.RestartGame(inventory, market, GameOn);

            while (GameOn) // main loop for the game
            {
                market.ListItemsMarket(market);
                int i = market.ItemAnswer(market.items.Count) - 1;
                if (inventory.InventorySpace > 0)
                {
                    inventory.AddItem(inventory, market, i);
                    inventory.ListItemsInventory(inventory);
                }
                else // The game ends if inventory is 0
                {
                    GameOn = false;
                }
            }
            Console.Clear();

            Console.WriteLine("All these stolen items are too heavy and you died.");
            Console.WriteLine("");
            Console.WriteLine("Type Y or N to play again.");
            if (utility.YesOrNo())
            {
            }
            else
            {
                return;
            }
        }
    }
}