class SandwichShop{
    private static SandwichBuilder sandwichBuilder = new SandwichBuilder();
    private static IngredientBuilder ingredientBuilder = new IngredientBuilder();
    public static List<Sandwich> sandwiches { get; private set; } = new List<Sandwich>() {
            sandwichBuilder
            .WithIngredients(new List<Ingredient>(){
                ingredientBuilder
                .WithQuantity(1)
                .WithUnit(Unit.None)
                .WithName(IngredientName.Bread).Build(),
                ingredientBuilder
                .WithQuantity(1)
                .WithUnit(Unit.None)
                .WithName(IngredientName.Ham).Build(),
                ingredientBuilder
                .WithQuantity(10)
                .WithUnit(Unit.Grams)
                .WithName(IngredientName.Butter).Build()
            })
            .WithName("Jambon beurre")
            .WithPrice(3.5f)
            .Build(),
            sandwichBuilder
            .WithIngredients(new List<Ingredient>(){
                ingredientBuilder
                    .WithQuantity(1)
                    .WithUnit(Unit.None)
                    .WithName(IngredientName.Bread).Build(),
                ingredientBuilder
                    .WithQuantity(1)
                    .WithUnit(Unit.None)
                    .WithName(IngredientName.Egg).Build(),
                ingredientBuilder
                    .WithQuantity(0.5f)
                    .WithUnit(Unit.None)
                    .WithName(IngredientName.Tomato).Build(),
                ingredientBuilder
                    .WithQuantity(1)
                    .WithUnit(Unit.None)
                    .WithName(IngredientName.Chicken)
                    .Build(),
                ingredientBuilder
                    .WithQuantity(10)
                    .WithUnit(Unit.Grams)
                    .WithName(IngredientName.Mayonnaise).Build(),
                ingredientBuilder
                    .WithQuantity(10)
                    .WithUnit(Unit.Grams)
                    .WithName(IngredientName.Salad).Build()
            })
            .WithName("Poulet crudite")
            .WithPrice(5f)
            .Build(),
            sandwichBuilder
            .WithIngredients(new List<Ingredient>() {
                ingredientBuilder
                    .WithQuantity(1)
                    .WithUnit(Unit.None)
                    .WithName(IngredientName.Bread).Build(),
                ingredientBuilder
                    .WithQuantity(50)
                    .WithUnit(Unit.Grams)
                    .WithName(IngredientName.Tuna).Build(),
                ingredientBuilder
                    .WithQuantity(0.5f)
                    .WithUnit(Unit.None)
                    .WithName(IngredientName.Tomato).Build(),
                ingredientBuilder
                    .WithQuantity(10)
                    .WithUnit(Unit.Grams)
                    .WithName(IngredientName.Mayonnaise).Build(),
                ingredientBuilder
                    .WithQuantity(10)
                    .WithUnit(Unit.Grams)
                    .WithName(IngredientName.Salad).Build()
            })
            .WithName("Dieppois")
            .WithPrice(4.5f)
            .Build()
        };

}


// class SandwichShop{
//     public static List<Sandwich> sandwiches { get; private set; } = new List<Sandwich>() {
//             new Sandwich(new List<Ingredient>() {
//             new Ingredient(1, Unit.None, IngredientName.Bread),
//             new Ingredient(1, Unit.None, IngredientName.Ham),
//             new Ingredient(10, Unit.Grams, IngredientName.Butter),
//         }, "Jambon beurre", 3.5f),
//         new Sandwich(new List<Ingredient>() {
//             new Ingredient(1, Unit.None, IngredientName.Bread),
//             new Ingredient(1, Unit.None, IngredientName.Egg),
//             new Ingredient(0.5f, Unit.None, IngredientName.Tomato),
//             new Ingredient(1, Unit.None, IngredientName.Chicken),
//             new Ingredient(10, Unit.Grams, IngredientName.Mayonnaise),
//             new Ingredient(10, Unit.Grams, IngredientName.Salad),
//         }, "Poulet crudite", 5f),
//         new Sandwich(new List<Ingredient>() {
//             new Ingredient(1, Unit.None, IngredientName.Bread),
//             new Ingredient(50, Unit.Grams, IngredientName.Tuna),
//             new Ingredient(0.5f, Unit.None, IngredientName.Tomato),
//             new Ingredient(10, Unit.Grams, IngredientName.Mayonnaise),
//             new Ingredient(10, Unit.Grams, IngredientName.Salad),
//         }, "Dieppois", 4.5f),
//         };

// }