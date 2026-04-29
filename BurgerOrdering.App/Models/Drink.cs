namespace BurgerOrdering.App.Models;
// Represents a drink option for the order
public class Drink : MenuItem
{
    public string Flavor { get; set; }

    public Drink(string name, double price, int prepTime, string flavor = "")
        : base(name, price, prepTime)
    {
        Flavor = flavor;
    }

    public override string ToString()
    {
        return string.IsNullOrEmpty(Flavor)
            ? Name
            : $"{Name} ({Flavor})";
    }
}