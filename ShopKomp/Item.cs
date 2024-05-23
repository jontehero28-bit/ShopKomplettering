public class Item
{
    public string? Name { get; set; }
    //items namn
    int _value = Random.Shared.Next(10, 200);
    public int Value { get { return _value; } set { } }
    protected int _requiredSpace = Random.Shared.Next(1, 20);
    public int Space
    {
        get { return _requiredSpace; }
        set
        {
            if (value >= 0 && value < 20)
            {
                _requiredSpace = value;

            }
        }
    }
    //Limits the required space value between 1 and 20

}
//Item Class created
public class VegetableItem : Item
{
    public string? Vegetables { get; set; }
    string[] _namesVegetableItems = { "Tomato", "Carrot", "Potato", "Broccoli", "Beet"};

    private static bool _lastWasFresh = false;
    //Need to check if the item was fresh so a bool here.

    public VegetableItem()
    {
        int _number = Random.Shared.Next(_namesVegetableItems.Length);
        Name = GetNames(_number);
        Vegetables = GetFresh();
        _lastWasFresh = !_lastWasFresh;
    }
    //constructor for printing out the vegetable items.

    public virtual string GetNames(int item)
    {
        string i = _namesVegetableItems[item];

        return i;
    }
    //To get the names for the items method.
    public string GetFresh()
    {
        string i;
        if (_lastWasFresh)
        {
            i = "Fresh ";
        }
        else
        {
            i = "Moldy ";
        }
        return i;

    }
    //get the "fresh" or "moldy" for the vegetables.
}
//Creates a subclass vegetables item for superclass item
public class SmellyItem : VegetableItem
{
    public string? ItemTotal { get; set; }
    string[] _namesSmellyItems = { "Horseradish", "Ginger", "Garlic", "Durian", "Sprouts"};
    private static bool _lastIsSmelly = false;
    bool _isBig = false;
    public bool IsBig
    {
        get
        {
            return _isBig;
        }
        set
        {
            _isBig = value;
        }
    }
    public SmellyItem()
    {
        int number = Random.Shared.Next(_namesSmellyItems.Length);
        Name = GetNames(number);
        ItemTotal = GetSmell();
        if (Space >= 18)
        {
            IsBig = true;
        }
        _lastIsSmelly = !_lastIsSmelly;
    }
    //simillar structure to previous subclass. This is construct.
    public override string GetNames(int item)
    {
        string i = _namesSmellyItems[item];

        return i;
    }
    // Chngae getnames method so it would follow my smellyitem list
    public string GetSmell()
    {
        string i;
        if (_lastIsSmelly)
        {
            i = "Yucky ";
        }
        else
        {
            i = "Delicious ";
        }
        return i;
    }
    //Simmillar to previous one. Get one of these alternatives for the vegetables.


}
//subclass smellyitem to subclass vegetable item and superclass item.