class Sandwich {
    public List<Ingredient> Ingredients { get; private set; }

    public Sandwich(List<Ingredient> ingredients) {
        Ingredients = new List<Ingredient>();
    }
}