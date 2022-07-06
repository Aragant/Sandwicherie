class SandwichBuilder {
    private List<Ingredient> ingredients;
    private string name;
    private float price;

    public SandwichBuilder() {
    }

    public SandwichBuilder WithIngredients(List<Ingredient> ingredients) {
        this.ingredients = ingredients;
        return this;
    }

    public SandwichBuilder WithName(string name) {
        this.name = name;
        return this;
    }

    public SandwichBuilder WithPrice(float price) {
        this.price = price;
        return this;
    }

    public Sandwich Build() {
        return new Sandwich(ingredients, name, price);
    }
}