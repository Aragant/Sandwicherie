class SandwichPrompter {
    public SandwichShop sandwichShop = new SandwichShop();
    private static ISandwichParser CommandMethod;
    private static ISandwichOrder OrderMethod;

    public static void Welcome() {
        Console.WriteLine("Welcome to the Sandwich Shop!");
        CommandChoice();
        Console.WriteLine("We have the following sandwiches available:");
        foreach (Sandwich sandwich in SandwichShop.sandwiches) {
            Console.WriteLine($"    > {sandwich.name} - {sandwich.price}e");
        }
        
    }
    public static void TakeOrder() {
        Console.WriteLine("What kind of sandwich would you like?");
        string? order = Console.ReadLine();
        if (order == null) {
            Console.WriteLine("Invalid order");
            return;
        }
        
        Dictionary<Sandwich, int> sandwiches = CommandMethod.Parse(order);

        if(sandwiches.Count() > 0) {
            OrderChoice();
            OrderMethod.DisplayOrder(sandwiches);
            return;
        }else
        {
            TakeOrder();
            return;
        }
    }

    static void  CommandChoice() {
        Console.WriteLine("What kind of order would you like?");
        Console.WriteLine("1.Take order with commande line");
        Console.WriteLine("2.Take order with JSON");
        Console.WriteLine("3.Take order with XML");
        
        int choice = -1;

        try {
            choice = int.Parse(Console.ReadLine());
        } catch (Exception e) {
            Console.WriteLine("invalide choice");
            CommandChoice();
        }
        
        if (choice == 1) {
            CommandMethod = new SandwichParserCommandLine();
        } else if (choice == 2) {
            CommandMethod = new SandwichParserJSON();
        } else if (choice == 3) {
            CommandMethod = new SandwichParserXML();
        } else {
            Console.WriteLine("Invalid choice");
            CommandChoice();
        }
    }

    static void OrderChoice(){
        Console.WriteLine("What kind of billing would you like?");
        Console.WriteLine("1.Take billing with command line");
        Console.WriteLine("2.Take billing with JSON");
        Console.WriteLine("3.Take billing with XML");
        
        int choice = -1;

        try {
            choice = int.Parse(Console.ReadLine());
        } catch (Exception e) {
            Console.WriteLine("invalide choice");
            OrderChoice();
        }
        
        if (choice == 1) {
            OrderMethod = new SandwichOrderCommandLine();
        } else if (choice == 2) {
            OrderMethod = new SandwichOrderJSON();
        } else if (choice == 3) {
            OrderMethod = new SandwichOrderXML();
        } else {
            Console.WriteLine("Invalid choice");
            OrderChoice();
        }
    }
}