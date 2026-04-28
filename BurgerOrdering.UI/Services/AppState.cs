using BurgerOrdering.App.Models;

namespace BurgerOrdering.UI.Services;

public class AppState
{
    public Customer Customer { get; set; } = new Customer();
    public Order Order { get; set; } = new Order();
}