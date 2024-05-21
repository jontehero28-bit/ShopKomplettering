//Skapa klasserna och functions för kommandon
Shop shop = new();
Inventory inventory = new();
Market market = new();

bool GameOn = true;      //bool för att spelet skulle köras

while (true)
{

    //metoder för att starta spelet ska vara här
    while (GameOn == true)
    {
        market.ListStealItemMarket(market);
    }

}

