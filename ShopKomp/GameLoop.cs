public class GameLoop
{
    Utility utility = new(); // think of it as a collection of functions
    Market market = new();
    Inventory inventory = new();
    // Utility, Market, and Inventory classes are instantiated

    public void Run()
    {
        bool game = false; // variable for game state

        while (true)
        {
            // method for starting the game and then restarting it
            game = utility.RestartGame(inventory, market, game);

            while (game) // main loop for the game
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
                    game = false;
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