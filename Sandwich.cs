class Sandwich {
    public List<Ingredient> Ingredients { get; private set; }

    public float price { get; private set; }

    public string name { get; private set; }

    public Sandwich(List<Ingredient> ingredients, string name, float price)
    {
        this.Ingredients = ingredients;
        this.name = name;
        this.price = price;
    }
}