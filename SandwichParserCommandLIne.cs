class SandwichParserCommandLine: ISandwichParser {
    // public SandwichShop sandwichShop =  new SandwichShop();
    public Dictionary<Sandwich, int> Parse(string order) {
        Dictionary<Sandwich, int> sandwiches = new Dictionary<Sandwich, int>();

        String[] orderArray = order.Split(',');
        foreach (string sandwich in orderArray){
            List<string> sandwichTrim =  sandwich.Trim().Split(' ').ToList();
            string quantityStr = sandwichTrim[0];

            if(int.TryParse(quantityStr, out int quantity)){
                sandwichTrim.RemoveAt(0);
                string sandwichName = string.Join(" ", sandwichTrim);

                Sandwich currentSandwich = ISandwichParser.IsPresentInSandwichShop(sandwichName);
                if(currentSandwich != null){
                    if(ISandwichParser.IsPresentInSandwichDictionary(sandwiches, currentSandwich)){
                        sandwiches[currentSandwich] += quantity;
                    }
                    else{
                        sandwiches.Add(currentSandwich, quantity);
                    }
                }
                else{
                    Console.WriteLine("Sorry, we don't have that sandwich");
                    return new Dictionary<Sandwich, int>();
                }
            }
            else{
                Console.WriteLine("Invalid quantity");
                return new Dictionary<Sandwich, int>();
            }
        }
        return sandwiches;
    }
}