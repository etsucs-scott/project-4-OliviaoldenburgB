namespace BurgerOrdering.App.Models;

public class Dessert : MenuItem
{
    // 🔥 REQUIRED for JSON deserialization
    public Dessert() : base("", 0, 0) { }

    public Dessert(string name, double price, int prepTime)
        : base(name, price, prepTime) { }
}