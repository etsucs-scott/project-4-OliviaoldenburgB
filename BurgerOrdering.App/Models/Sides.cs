namespace BurgerOrdering.App.Models;

public class Side
{
    public string Name { get; set; } = "";
    public double Price { get; set; }
    public int PrepTime { get; set; }

    public Side(string name, double price, int prepTime)
    {
        Name = name;
        Price = price;
        PrepTime = prepTime;
    }
}