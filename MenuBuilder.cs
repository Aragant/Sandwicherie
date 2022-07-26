class MenuBuilder
{
    private List<Sandwich> Sandwichs;
    private String Drink;
    private String Name;
    private float Price;

    public MenuBuilder()
    {
    }

    public MenuBuilder WithSandwichs(List<Sandwich> sandwichs)
    {
        this.Sandwichs = sandwichs;
        return this;
    }

    public MenuBuilder WithDrink(String drink)
    {
        this.Drink = drink;
        return this;
    }

    public MenuBuilder WithName(String name)
    {
        this.Name = name;
        return this;

    }
    public MenuBuilder WithPrice(float price)
    {
        this.Price = price;
        return this;
    }

    public Menu Build()
    {
        return new Menu(this.Sandwichs, this.Drink, this.Name, this.Price);
    }
}