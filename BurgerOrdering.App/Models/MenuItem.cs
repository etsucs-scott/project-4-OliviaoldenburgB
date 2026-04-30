namespace BurgerOrdering.App.Models;

// Base class for menu items with common properties
public abstract class MenuItem
{
    public string Name { get; set; } = "";
    public double Price { get; set; }
    public int PrepTime { get; set; }

    // 🔥 REQUIRED for JSON deserialization
    protected MenuItem() { }

    public MenuItem(string name, double price, int prepTime)
    {
        Name = name;
        Price = price;
        PrepTime = prepTime;
    }
}