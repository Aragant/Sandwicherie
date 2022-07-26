class Menu: Item
{
    public List<Sandwich> Sandwichs { get; private set; }
    public String Drink { get; private set; }
    public String Name { get; private set; }
    public float Price { get; private set; }

    public Menu(List<Sandwich> sandwichs, String drink, String name, float price)
    {
        this.Sandwichs = sandwichs;
        this.Drink = drink;
        this.Name = name;
        this.Price = price;
    }
}
