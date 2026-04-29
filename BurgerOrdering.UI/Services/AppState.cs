using BurgerOrdering.App.Models;
// Holds shared data so all pages can access the current order
namespace BurgerOrdering.UI.Services;

public class AppState
{
    public Customer Customer { get; set; } = new Customer();
    public Order Order { get; set; } = new Order();
}