class SandwichShop{
    private static SandwichBuilder sandwichBuilder = new SandwichBuilder();
    
    private static IngredientBuilder ingredientBuilder = new IngredientBuilder();


    //private static ISandwichImport sandwichImport = new ReadJson();
    private static ISandwichImport sandwichImport = new ReadInApp();

    private static IMenuImport menuImport = new MenuImportInApp();
    
    public static List<Sandwich> sandwiches = sandwichImport.GetSandwiches();

    public static List<Menu> menus = menuImport.GetMenus(); 

    public static Sandwich GetSandwich(string sandwichName) =>
         sandwiches.FirstOrDefault(sandwich => sandwich.name == sandwichName);

    public static Menu GetMenu(string menuName) =>
         menus.FirstOrDefault(menu => menu.Name == menuName);

}