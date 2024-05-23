public class Inventory //inventoryclass
{
    int _inventorySpace = 20;
    public int InventorySpace
    {
        get
        {
            if (_inventorySpace > 0)
            {
                return _inventorySpace;
            }
            else
            {
                _inventorySpace = 0;
                return _inventorySpace;
            }

        }
        set
        {
            if (value > 0 && value < 21)
            {
                _inventorySpace = value;
            }
            else
            {
                _inventorySpace = 0;
            }
        }
    }

    //gör så man inte kan ändra på värdet på space
    public Stack<Item> Items = new();
    public void ListItemsInventory(Inventory inventory)
    {
        Console.Clear();
        Console.WriteLine("Du har: ");
        foreach (Item i in inventory.Items)
        {
            if (i is VegetableItem)
            {
                Console.Write(((VegetableItem)i).Vegetables);
            }
            if (i is SmellyItem)
            {
                Console.Write(((SmellyItem)i).IsBig);
                Console.Write(((SmellyItem)i).Vegetables);
            }
            Console.Write(i.Name + ", ");

        }
        Console.WriteLine("och plats kvar i inventory " + inventory.InventorySpace);
        //void för att skriva ut alla items i inventory som skriver även ut weight och Length om de har det
    }
    public void ResetGameInventory(Inventory inventory)
    {
        inventory.InventorySpace = 20;
        inventory.Items.Clear();
    }
    //startar om inventory, tar bort allt i det och tar upp space till max
    public void AddItem(Inventory inventory, Market market, int index)
    {
        inventory.InventorySpace -= market.items[index].Space;
        inventory.Items.Push(market.items[index]);
        market.items.RemoveAt(index);
    }
}
//skapar classen inventory med en lista som kan innehålla items
