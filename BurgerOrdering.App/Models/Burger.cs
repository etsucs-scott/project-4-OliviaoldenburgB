namespace BurgerOrdering.App.Models;

public class Burger
{
    public string Protein { get; set; } = "";
    public string Cheese { get; set; } = "";
    public string Sauce { get; set; } = "";

    public Dictionary<string, double> AddOnPrices { get; set; } = new();
    public HashSet<string> AddOns { get; set; } = new();

    // Calculate total price of burger
    public double GetTotalPrice()
    {
        double total = 0;

        if (Protein == "Beef") total += 6;
        if (Protein == "Steak") total += 8;
        if (Protein == "Chicken") total += 5;

        if (Cheese == "Cheddar" || Cheese == "American") total += 1;
        if (Cheese == "Swiss") total += 1.5;

        if (Sauce == "BBQ") total += 1;
        if (Sauce == "Special") total += 1.5;

        foreach (var item in AddOnPrices)
            total += item.Value;

        return total;
    }

    // Calculate prep time
    public int GetPrepTime()
    {
        int time = 5;

        if (Protein == "Steak") time += 5;
        if (Protein == "Chicken") time += 3;

        time += AddOns.Count;

        return time;
    }
}