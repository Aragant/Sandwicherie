class SandwichShop{
    public static List<Sandwich> sandwiches { get; private set; } = new List<Sandwich>() {
            new Sandwich(new List<Ingredient>() {
            new Ingredient(1, Unit.None, IngredientName.Bread),
            new Ingredient(1, Unit.None, IngredientName.Ham),
            new Ingredient(10, Unit.Grams, IngredientName.Butter),
        }, "Jambon beurre", 3.5f),
        new Sandwich(new List<Ingredient>() {
            new Ingredient(1, Unit.None, IngredientName.Bread),
            new Ingredient(1, Unit.None, IngredientName.Egg),
            new Ingredient(0.5f, Unit.None, IngredientName.Tomato),
            new Ingredient(1, Unit.None, IngredientName.Chicken),
            new Ingredient(10, Unit.Grams, IngredientName.Mayonnaise),
            new Ingredient(10, Unit.Grams, IngredientName.Salad),
        }, "Poulet crudite", 5f),
        new Sandwich(new List<Ingredient>() {
            new Ingredient(1, Unit.None, IngredientName.Bread),
            new Ingredient(50, Unit.Grams, IngredientName.Tuna),
            new Ingredient(0.5f, Unit.None, IngredientName.Tomato),
            new Ingredient(10, Unit.Grams, IngredientName.Mayonnaise),
            new Ingredient(10, Unit.Grams, IngredientName.Salad),
        }, "Dieppois", 4.5f),
        };

}