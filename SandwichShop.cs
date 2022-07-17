class SandwichShop{
    private static SandwichBuilder sandwichBuilder = new SandwichBuilder();
    private static IngredientBuilder ingredientBuilder = new IngredientBuilder();
    private static ISandwichImport sandwichImport = new ReadJson();
    public static List<Sandwich> sandwiches = sandwichImport.GetSandwiches();

}