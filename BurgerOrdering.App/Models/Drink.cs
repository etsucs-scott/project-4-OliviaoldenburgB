namespace BurgerOrdering.App.Models;

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