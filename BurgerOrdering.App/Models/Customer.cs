namespace BurgerOrdering.App.Models;

// Stores customer information like balance and teacher status
public class Customer
{
    public double Balance { get; set; } = 20;
    public bool IsTeacher { get; set; } = false;

    // Deduct money safely
    public void Deduct(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
    }

    // Add funds safely
    public void AddFunds(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative.");

        Balance += amount;
    }
}