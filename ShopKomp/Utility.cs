public class Utility
{
    public int GetNumber()
    {
        string? i = "";

        int _number;
        while (!int.TryParse(i, out _number) == true) //tryparse
        {
            i = Console.ReadLine();
            if (!int.TryParse(i, out _number) == true)
            {
                Console.WriteLine("DU MÅSTE SKRIVA ETT NUMMERRRRRRRRR");  //check if it a number. if not print out the message

            }
            
        }  //run the loop unyil user inputs a valid number.
        
        return _number;  //return the value input
        
    }
    //check that it is a number

    public bool YesOrNo() //if user wants to play again input Y
    {
        string? i = Console.ReadLine();
        if (i.ToUpper() == "Y")
        {
            Console.Clear();
            return true;
        }
        else//else game over and stop the while loop
        {
            return false;
        }

    }

    public bool RestartGame(Inventory inventory, Market market, bool GameOn) //method to restart the game. Should look after the yesorno inpit
    {
        ResetGame(inventory, market);
        GameOn = true;
        return GameOn;
    }
    
    
    public void ResetGame(Inventory inventory, Market market) //resets the game and all the values
    {
        inventory.ResetGameInventory(inventory);
        market.MarketBeginGame(market);   //randomizes the market items again.
    }
}

