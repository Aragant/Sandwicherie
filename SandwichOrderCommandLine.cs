using Acme.Utils;
class SandwichOrderCommandLine: ISandwichOrder {
    private SandwichShop SandwichShop = new SandwichShop();

    public void DisplayOrder(Dictionary<Sandwich, int> sandwiches) {
        float totalPrice = 0;
        Console.WriteLine("Your order is:");
        foreach (KeyValuePair<Sandwich, int> sandwich in sandwiches) {
            Console.WriteLine($"    >{sandwich.Value} {sandwich.Key.name} :");
            Sandwich currentSandwich = sandwich.Key;
            foreach (Ingredient ingredient in currentSandwich.Ingredients) {
                Console.WriteLine($"        - {ingredient.Quantity}{ingredient.Unit.ToDescriptionString()} {ingredient.Name.ToDescriptionString()}");
            }
            totalPrice += currentSandwich.price * sandwich.Value;
            Console.WriteLine($"    Price : {currentSandwich.price * sandwich.Value}e");
        }

        Console.WriteLine($"Total price : {totalPrice}e");
    }

    public static Sandwich GetSandwich(string sandwichName) => 
         SandwichShop.sandwiches.FirstOrDefault(sandwich => sandwich.name == sandwichName);
    

}