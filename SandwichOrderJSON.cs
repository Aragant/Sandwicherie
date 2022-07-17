using Newtonsoft.Json.Linq;
using Acme.Utils;
class SandwichOrderJSON : ISandwichOrder
{
    public void DisplayOrder(Dictionary<Sandwich, int> sandwiches)
    {
        float totalPrice = 0;
        JObject jsonOrder = new JObject();
        var sandwichsToAdd = new JArray();
        foreach (KeyValuePair<Sandwich, int> sandwich in sandwiches) {
            var dataSandwich = new JObject();
            dataSandwich["name"] = sandwich.Key.name;
            dataSandwich["quantity"] = sandwich.Value;

            Sandwich currentSandwich = sandwich.Key;
            JArray ingredients = new JArray();
            var ingredientToAdd = new JObject();
            foreach (Ingredient ingredient in currentSandwich.Ingredients) {
                ingredientToAdd["quantity"] = ingredient.Quantity;
                ingredientToAdd["unit"] = ingredient.Unit.ToDescriptionString();
                ingredientToAdd["name"] = ingredient.Name.ToDescriptionString();
                ingredients.Add(ingredientToAdd);
            }
            dataSandwich["ingredient"] = ingredients;
            totalPrice += currentSandwich.price * sandwich.Value;
            dataSandwich["price"] = currentSandwich.price * sandwich.Value;
            sandwichsToAdd.Add(dataSandwich);
        }
        jsonOrder["sandwichs"] = sandwichsToAdd;
        jsonOrder["totalPrice"] = totalPrice;
        var jsonToOutput = jsonOrder.ToString();
        Console.WriteLine(jsonToOutput);
    }
}