namespace BurgerOrdering.App.Models;

public abstract class MenuItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int PrepTime { get; set; }

    public MenuItem(string name, double price, int prepTime)
    {
        Name = name;
        Price = price;
        PrepTime = prepTime;
    }
}