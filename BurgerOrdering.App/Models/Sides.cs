namespace BurgerOrdering.App.Models;

// Represents a side item with name, price, and prep time
public class Side : MenuItem
{
    // REQUIRED for JSON deserialization
    public Side() : base("", 0, 0) { }

    public Side(string name, double price, int prepTime)
        : base(name, price, prepTime) { }
}