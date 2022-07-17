using Newtonsoft.Json.Linq;
class ReadJson: ISandwichImport {

    public List<Sandwich> GetSandwiches() {
        List<Sandwich> sandwiches = new List<Sandwich>();
        SandwichBuilder sandwichBuilder = new SandwichBuilder();
        var ingredientBuilder = new IngredientBuilder();
        var json = File.ReadAllText("sandwich.json");
        JObject jsonObject = JObject.Parse(json);
        JArray sandwichesArray = jsonObject["sandwiches"].ToObject<JArray>();
        foreach (var sandwich in sandwichesArray) {
            var ingredients = new List<Ingredient>();
            var ingredientsArray = sandwich["ingredients"].ToObject<JArray>();
            foreach (var ingredient in ingredientsArray) {
                var quantity = ingredient["quantity"].ToObject<float>();
                var unit = ingredient["unit"].ToObject<Unit>();
                var nameIngredient = ingredient["name"].ToObject<IngredientName>();
                ingredients.Add(ingredientBuilder.WithQuantity(quantity).WithUnit(unit).WithName(nameIngredient).Build());
            }
            string name = sandwich["name"].ToObject<string>();
            var price = sandwich["price"].ToObject<float>();
            sandwiches.Add(sandwichBuilder.WithIngredients(ingredients).WithName(name).WithPrice(price).Build());
        }
        return sandwiches;
    }
}