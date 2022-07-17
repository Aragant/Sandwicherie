using Newtonsoft.Json.Linq;

class SandwichParserJSON : ISandwichParser{
    public Dictionary<Sandwich, int> Parse(string order)
    {
        Dictionary<Sandwich, int> sandwiches = new Dictionary<Sandwich, int>();
        var json = File.ReadAllText("commandAsk.json");
        JObject jsonObject = JObject.Parse(json);
        JArray sandwichesArray = jsonObject["command"].ToObject<JArray>();
        foreach (var sandwich in sandwichesArray) {
            int quantity = sandwich["quantity"].ToObject<int>();
            string name = sandwich["name"].ToObject<string>();

            Sandwich currentSandwich = ISandwichParser.IsPresentInSandwichShop(name);
            
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

         return sandwiches;
    }

}