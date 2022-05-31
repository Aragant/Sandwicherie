class SandwichParser{
    // public SandwichShop sandwichShop =  new SandwichShop();
    public static Dictionary<string, int> Parse(string order) {
        Dictionary<string, int> sandwiches = new Dictionary<string, int>();

        String[] orderArray = order.Split(',');
        foreach (string sandwich in orderArray){
            List<string> sandwichTrim =  sandwich.Trim().Split(' ').ToList();
            string quantityStr = sandwichTrim[0];

            if(int.TryParse(quantityStr, out int quantity)){
                sandwichTrim.RemoveAt(0);
                string sandwichName = string.Join(" ", sandwichTrim);

                if(IsPresentInSandwichShop(sandwichName)){
                    if(IsPresentInSandwichDictionary(sandwiches, sandwichName)){
                        sandwiches[sandwichName] += quantity;
                    }
                    else{
                        sandwiches.Add(sandwichName, quantity);
                    }
                }
                else{
                    Console.WriteLine("Sorry, we don't have that sandwich");
                    return new Dictionary<string, int>();
                }
            }
            else{
                Console.WriteLine("Invalid quantity");
                return new Dictionary<string, int>();
            }
        }
        return sandwiches;
    }

    public static bool IsPresentInSandwichShop(string sandwich){
        foreach (Sandwich sandwichShopSandwich in SandwichShop.sandwiches){
            if(sandwichShopSandwich.name == sandwich){
                return true;
            }
        }
        return false;
    }

    private static bool IsPresentInSandwichDictionary(Dictionary<string, int> sandwiches, string sandwich){
        foreach (KeyValuePair<string, int> sandwichDictionary in sandwiches){
            if(sandwichDictionary.Key == sandwich){
                return true;
            }
        }

        return false;
    }

}