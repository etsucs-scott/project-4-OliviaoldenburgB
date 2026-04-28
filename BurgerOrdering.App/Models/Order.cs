namespace BurgerOrdering.App.Models;

public class Order
{
    public Burger Burger { get; set; } = new Burger();
    public List<Side> Sides { get; set; } = new();
    public Dessert? Dessert { get; set; }

    public double GetTotalPrice()
    {
        double total = Burger.GetTotalPrice();

        foreach (var side in Sides)
            total += side.Price;

        if (Dessert != null)
            total += Dessert.Price;

        return total;
    }

    public int GetTotalPrepTime()
    {
        int time = Burger.GetPrepTime();

        foreach (var side in Sides)
            time += side.PrepTime;

        if (Dessert != null)
            time += Dessert.PrepTime;

        return time;
    }
}