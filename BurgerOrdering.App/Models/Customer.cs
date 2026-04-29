namespace BurgerOrdering.App.Models;
// Stores customer information like balance and teacher status
public class Customer
{
    public double Balance { get; set; } = 20;
    public bool IsTeacher { get; set; } = false;
}