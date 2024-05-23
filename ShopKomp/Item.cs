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
    //sätter gränserna att ett items space value bara kan vara mellan 0 och 20

}
//skapar klassen items
public class VegetableItem : Item
{
    public string? Vegetables { get; set; }
    string[] _namesVegetableItems = { "Tomato", "Carrot", "Potato", "Broccoli", "Beet"};

    private static bool _lastWasFresh = false;
    //bool för att kolla om senaste item var heavy

    public VegetableItem()
    {
        int _number = Random.Shared.Next(_namesVegetableItems.Length);
        Name = GetNames(_number);
        Vegetables = GetFresh();
        _lastWasFresh = !_lastWasFresh;
    }
    //konstruktor

    public virtual string GetNames(int item)
    {
        string i = _namesVegetableItems[item];

        return i;
    }
    //metod för att få ut namn på item
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
    //metod för att få ut Weight på items
}
//skapar subclass weighted items av item
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
    public override string GetNames(int item)
    {
        string i = _namesSmellyItems[item];

        return i;
    }
    //ändrar metoden getNames så den följer listan namesWeapon istället
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
    //metod för att få längd på Weapon


}
//subclass weapon av weightedItems
public class ShopItem : Item
{
    public int Cost { get; set; }

    bool _soldOut = false;
    public bool SoldOut
    {
        get
        {
            return _soldOut;
        }
        set
        {
            _soldOut = value;
        }
    }
    public ShopItem()
    {
        Cost = (Space * 10);
    }
}