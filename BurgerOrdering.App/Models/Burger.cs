namespace BurgerOrdering.App.Models;

// Stores the burger selections and calculates price and prep time
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

        string bun = Bun.ToLower();
        string protein = Protein.ToLower();
        string cheese = Cheese.ToLower();
        string sauce = Sauce.ToLower();

        total += bun switch
        {
            "sesame seed" => 1.00,
            "pretzel"     => 1.50,
            "brioche"     => 2.00,
            "whole wheat" => 1.00,
            _ => 0
        };

        total += protein switch
        {
            "beef"    => 6.00,
            "steak"   => 8.00,
            "chicken" => 5.00,
            _ => 0
        };

        total += cheese switch
        {
            "american" or "cheddar" => 1.00,
            "swiss"                 => 1.50,
            "pepper jack"           => 1.25,
            "provolone"             => 1.25,
            _ => 0
        };

        total += sauce switch
        {
            "bbq"            => 1.00,
            "ranch"          => 0.50,
            "special sauce"  => 1.50,
            _ => 0
        };

        foreach (var item in AddOnPrices ?? new Dictionary<string, double>())
            total += item.Value;

        return total;
    }

    public int GetPrepTime()
    {
        int time = 5;

        string protein = Protein.ToLower();

        if (protein == "steak")   time += 5;
        if (protein == "chicken") time += 3;

        time += (AddOnPrices?.Count ?? 0);

        return time;
    }
}