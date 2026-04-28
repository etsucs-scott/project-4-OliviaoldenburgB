namespace BurgerOrdering.App.Models;

public class Dessert
{
    public string Name { get; set; } = "";
    public double Price { get; set; }
    public int PrepTime { get; set; }

    public Dessert() { }

    public Dessert(string name, double price, int prepTime)
    {
        Name = name;
        Price = price;
        PrepTime = prepTime;
    }
}