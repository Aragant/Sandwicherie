interface ISandwichParser {
    Dictionary<Sandwich, int> Parse(string order);

    public static Sandwich IsPresentInSandwichShop(string sandwich){
        foreach (Sandwich sandwichShopSandwich in SandwichShop.sandwiches){
            if(sandwichShopSandwich.name == sandwich){
                return sandwichShopSandwich;
            }
        }

        return null;
    }

    public static bool IsPresentInSandwichDictionary(Dictionary<Sandwich, int> sandwiches, Sandwich sandwich){
        if(sandwiches.ContainsKey(sandwich)){
            return true;
        }

        return false;
    }
}
