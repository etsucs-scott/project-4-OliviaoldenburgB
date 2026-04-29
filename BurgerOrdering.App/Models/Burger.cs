namespace BurgerOrdering.App.Models;

public class Burger
{
    public string Bun { get; set; } = "";
    public string Protein { get; set; } = "";
    public string Cheese { get; set; } = "";
    public string Sauce { get; set; } = "";
    public Dictionary<string, double> AddOnPrices { get; set; } = new();

    public double GetTotalPrice()
    {
        double total = 0;

        total += Bun switch
        {
            "Sesame Seed" => 1.00,
            "Pretzel"     => 1.50,
            "Brioche"     => 2.00,
            "Whole Wheat" => 1.00,
            _ => 0
        };

        total += Protein switch
        {
            "Beef"    => 6.00,
            "Steak"   => 8.00,
            "Chicken" => 5.00,
            _ => 0
        };

        total += Cheese switch
        {
            "American" or "Cheddar" => 1.00,
            "Swiss"                 => 1.50,
            "Pepper Jack"           => 1.25,
            "Provolone"             => 1.25,
            _ => 0
        };

        total += Sauce switch
        {
            "BBQ"           => 1.00,
            "Ranch"         => 0.50,
            "Special Sauce" => 1.50,
            _ => 0
        };

        foreach (var item in AddOnPrices)
            total += item.Value;

        return total;
    }

    public int GetPrepTime()
    {
        int time = 5;
        if (Protein == "Steak")   time += 5;
        if (Protein == "Chicken") time += 3;
        time += AddOnPrices.Count;
        return time;
    }
}