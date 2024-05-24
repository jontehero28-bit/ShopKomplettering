public class Inventory //inventoryclass
{

    
    int _inventorySpace = 20;

    public Stack<Item> Items = new();//items stack

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

    //fixed so that the could not change the limit to available space in the inventory.
    
    public void ListItemsInventory(Inventory inventory)  //Simillar to ListItemsMarket but intstead connected to inventory space.
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
                if (((SmellyItem)i).IsBig) //if isBig true print big
                {
                    Console.Write("Big ");
                }
                else if (!((SmellyItem)i).IsBig) //look if isBig false, if it is then print little
                {
                    Console.Write("Small ");
                }
                
            }
            Console.Write(i.Name + ", ");

        }
        Console.WriteLine("plats kvar i inventory " + inventory.InventorySpace);
        //Prints out all of the items in the inventory
        //also includes if it is big and smelly
    }
    public void ResetGameInventory(Inventory inventory)
    {
        inventory.InventorySpace = 20;
        inventory.Items.Clear();
    }
    //restart the inventory and reset inventory space
    public void AddItem(Inventory inventory, Market market, int index)
    {
        inventory.InventorySpace -= market.items[index].Space;
        inventory.Items.Push(market.items[index]);
        market.items.RemoveAt(index);
    }
}
//class items in inventory that puts the items that the player chose into the inventory