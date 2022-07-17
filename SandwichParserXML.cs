using System.Xml.Linq;

class SandwichParserXML : ISandwichParser{
    public Dictionary<Sandwich, int> Parse(string order)
    {


        Dictionary<Sandwich, int> sandwiches = new Dictionary<Sandwich, int>();
        var xml = File.ReadAllText("commandAsk.xml");
        
        XDocument doc1 = XDocument.Parse(xml, LoadOptions.PreserveWhitespace);  
        var commandData = doc1.Element("command");
        var commandSandwich = doc1.Element("sandwich");
        
        // Query the data and write out a subset of contacts
        foreach(var c in commandData.Descendants("sandwich")) {

            int quantity = int.Parse(c.Element("quantity").Value.Trim());
            string name = c.Element("name").Value.Trim();
            Console.WriteLine("Sandwich : {0} {1}", quantity, name);

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