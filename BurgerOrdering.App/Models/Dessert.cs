namespace BurgerOrdering.App.Models;

public class Dessert : MenuItem
{
    public Dessert(string name, double price, int prepTime)
        : base(name, price, prepTime) { }
}