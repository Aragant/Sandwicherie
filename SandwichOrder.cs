using Acme.Utils;
class SandwichOrder {
    private static SandwichShop SandwichShop = new SandwichShop();
    public static void DisplayOrder(Dictionary<string, int> sandwiches) {
        float totalPrice = 0;
        Console.WriteLine("Your order is:");
        foreach (KeyValuePair<string, int> sandwich in sandwiches) {
            Console.WriteLine($"    >{sandwich.Value} {sandwich.Key} :");
            Sandwich currentSandwich = GetSandwich(sandwich.Key);
            foreach (Ingredient ingredient in currentSandwich.Ingredients) {
                Console.WriteLine($"        - {ingredient.Quantity} {ingredient.Unit.ToDescriptionString()} {ingredient.Name.ToDescriptionString()}");
            }
            totalPrice += currentSandwich.price * sandwich.Value;
            Console.WriteLine($"    Price : {currentSandwich.price * sandwich.Value}e");
        }

        Console.WriteLine($"Total price : {totalPrice}e");
    }

    public static Sandwich GetSandwich(string sandwichName) {
        foreach (Sandwich sandwich in SandwichShop.sandwiches) {
            if (sandwich.name == sandwichName) {
                return sandwich;
            }
        }
        return null;
    }
}