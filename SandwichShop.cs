class SandwichShop{
    public List<Sandwich> sandwiches { get; private set; }

    public SandwichShop() {
        this.sandwiches = new List<Sandwich>();

        Sandwich jambonBeurre = new Sandwich(new List<Ingredient>() {
            new Ingredient(1, Unit.None, IngredientName.pain),
            new Ingredient(1, Unit.None, IngredientName.jambon),
            new Ingredient(10, Unit.Grams, IngredientName.beurre),
        });
    }
}