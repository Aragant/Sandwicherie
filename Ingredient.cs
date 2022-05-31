class Ingredient {
    public float Quantity { get; private set; }
    public Unit Unit { get; private set; }
    public IngredientName Name;

    public Ingredient(float quantity, Unit unit, IngredientName name)
    {
        this.Quantity = quantity;
        this.Unit = unit;
        this.Name = name;
    }
}