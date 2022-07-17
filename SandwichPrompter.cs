class SandwichPrompter {
    public SandwichShop sandwichShop = new SandwichShop();
    private static ISandwichParser CommandMethode;

    public static void Welcome() {
        Console.WriteLine("Welcome to the Sandwich Shop!");
        Console.WriteLine("We have the following sandwiches available:");
        foreach (Sandwich sandwich in SandwichShop.sandwiches) {
            Console.WriteLine($"    > {sandwich.name} - {sandwich.price}e");
        }
        CommandeChoice();
    }
    public static void TakeOrder() {
        Console.WriteLine("What kind of sandwich would you like?");
        string? order = Console.ReadLine();
        if (order == null) {
            Console.WriteLine("Invalid order");
            return;
        }
        
        Dictionary<Sandwich, int> sandwiches = CommandMethode.Parse(order);

        if(sandwiches.Count() > 0) {
            SandwichOrder.DisplayOrder(sandwiches);
            return;
        }else
        {
            TakeOrder();
            return;
        }
    }

    static void  CommandeChoice() {
        Console.WriteLine("What kind of sandwich would you like?");
        Console.WriteLine("1.Take order with commande line");
        Console.WriteLine("2.Take order with JSON");
        Console.WriteLine("3.Take order with XML");
        
        int choice = -1;

        try {
            choice = int.Parse(Console.ReadLine());
        } catch (Exception e) {
            Console.WriteLine("invalide choice");
            CommandeChoice();
        }
        
        if (choice == 1) {
            CommandMethode = new SandwichParserCommandLine();
        } else if (choice == 2) {
            CommandMethode = new SandwichParserCommandLine();
        } else if (choice == 3) {
            CommandMethode = new SandwichParserCommandLine();
        } else {
            Console.WriteLine("Invalid choice");
            CommandeChoice();
        }
    }
}