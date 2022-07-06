class IngredientBuilder {
    private float quantity;
    private Unit unit;
    private IngredientName name;

    public IngredientBuilder() {
    }

    public IngredientBuilder WithQuantity(float quantity) {
        this.quantity = quantity;
        return this;
    }

    public IngredientBuilder WithUnit(Unit unit) {
        this.unit = unit;
        return this;
    }

    public IngredientBuilder WithName(IngredientName name) {
        this.name = name;
        return this;
    }

    public Ingredient Build() {
        return new Ingredient(quantity, unit, name);
    }
}