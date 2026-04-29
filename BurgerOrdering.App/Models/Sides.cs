namespace BurgerOrdering.App.Models;

public class Side : MenuItem
{
    public Side(string name, double price, int prepTime)
        : base(name, price, prepTime) { }
}