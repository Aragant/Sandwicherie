using System.Xml.Linq;
using Acme.Utils;
class SandwichOrderXML : ISandwichOrder
{
    public void DisplayOrder(Dictionary<Sandwich, int> sandwiches)
    {
        float totalPrice = 0;
        var xmlOrder = new XElement("Orders");
        XElement sandwichToAdd = new XElement("sandwich");
        foreach (KeyValuePair<Sandwich, int> sandwich in sandwiches) {
            sandwichToAdd.Add(new XElement("name", sandwich.Key.name));
            sandwichToAdd.Add(new XElement("quantity", sandwich.Value));


            Sandwich currentSandwich = sandwich.Key;
            var ingredients = new XElement("ingredients");
            

            foreach (Ingredient ingredient in currentSandwich.Ingredients) {
                var ingredientToAdd = new XElement("ingredient",
                    new XElement("quantity", ingredient.Quantity),
                    new XElement("unit", ingredient.Unit.ToDescriptionString()),
                    new XElement("name", ingredient.Name.ToDescriptionString()));
                ingredients.Add(ingredientToAdd);
            }
            sandwichToAdd.Add(ingredients);
            totalPrice += currentSandwich.price * sandwich.Value;
            sandwichToAdd.Add(new XElement("price", currentSandwich.price * sandwich.Value));
            xmlOrder.Add(sandwichToAdd);
        }
        xmlOrder.Add(new XElement("total_price", totalPrice));
        var jsonToOutput = xmlOrder.ToString();
        Console.WriteLine(jsonToOutput);
    }
}