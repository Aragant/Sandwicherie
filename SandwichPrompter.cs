class SandwichPrompter {
    public SandwichShop sandwichShop = new SandwichShop();

    public static void Welcome() {
        Console.WriteLine("Welcome to the Sandwich Shop!");
        Console.WriteLine("We have the following sandwiches available:");
        foreach (Sandwich sandwich in SandwichShop.sandwiches) {
            Console.WriteLine($"    >{sandwich.name} - {sandwich.price}");
        }

    }
    public static void TakeOrder() {
        Console.WriteLine("What kind of sandwich would you like?");
        string? order = Console.ReadLine();
        Dictionary<string, int> sandwiches = SandwichParser.Parse(order);

        if(sandwiches.Count() > 0) {
            SandwichOrder.DisplayOrder(sandwiches);
            return;
        }else
        {
            TakeOrder();
        }
    }
}