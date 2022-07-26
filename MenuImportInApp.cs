class MenuImportInApp : IMenuImport
{
    private MenuBuilder MenuBuilder;

    public MenuImportInApp()
    {
        this.MenuBuilder = new MenuBuilder();
    }

    public List<Menu> GetMenus()
    {
        var sandwichsInMenuManga = new List<Sandwich>();
        sandwichsInMenuManga.Add(SandwichShop.GetSandwich("Jambon beurre"));
        sandwichsInMenuManga.Add(SandwichShop.GetSandwich("Jambon beurre"));

        var sandwichsInMenuTotal = new List<Sandwich>();
        sandwichsInMenuManga.Add(SandwichShop.GetSandwich("Jambon beurre"));
        sandwichsInMenuManga.Add(SandwichShop.GetSandwich("Jambon beurre"));
        sandwichsInMenuManga.Add(SandwichShop.GetSandwich("Dieppois"));
        sandwichsInMenuManga.Add(SandwichShop.GetSandwich("Dieppois"));
        sandwichsInMenuManga.Add(SandwichShop.GetSandwich("Poulet crudite"));

        return new List<Menu>()
        {
            MenuBuilder.WithSandwichs(sandwichsInMenuManga).WithName("Menu Manga").WithDrink("Eau").WithPrice(11).Build(),
            MenuBuilder.WithSandwichs(sandwichsInMenuTotal).WithName("Menu Total").WithDrink("Eau").WithPrice(20).Build(),
        };

    
    }

}
