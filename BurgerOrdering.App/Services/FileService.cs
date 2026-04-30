using System.Text.Json;
using System.Text.Json.Serialization;
using BurgerOrdering.App.Models;

namespace BurgerOrdering.App.Services;

public class FileService
{
    private readonly string _orderFile = "orders.json";
    private readonly string _customerFile = "customer.json";

    private readonly JsonSerializerOptions _options;

    public FileService()
    {
        _options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters =
            {
                new JsonStringEnumConverter()
            }
        };
    }

    // =========================
    // ORDER METHODS
    // =========================

    public async Task SaveOrdersAsync(List<Order> orders)
    {
        try
        {
            string json = JsonSerializer.Serialize(orders, _options);
            await File.WriteAllTextAsync(_orderFile, json);
        }
        catch (Exception ex)
        {
            throw new Exception("Error saving orders to file.", ex);
        }
    }

    public async Task<List<Order>> LoadOrdersAsync()
    {
        try
        {
            if (!File.Exists(_orderFile))
                return new List<Order>();

            string json = await File.ReadAllTextAsync(_orderFile);
            var orders = JsonSerializer.Deserialize<List<Order>>(json, _options);

            return orders ?? new List<Order>();
        }
        catch (Exception ex)
        {
            throw new Exception("Error loading orders from file.", ex);
        }
    }

    // =========================
    // CUSTOMER METHODS
    // =========================

    public async Task SaveCustomerAsync(Customer customer)
    {
        try
        {
            string json = JsonSerializer.Serialize(customer, _options);
            await File.WriteAllTextAsync(_customerFile, json);
        }
        catch (Exception ex)
        {
            throw new Exception("Error saving customer data.", ex);
        }
    }

    public async Task<Customer> LoadCustomerAsync()
    {
        try
        {
            if (!File.Exists(_customerFile))
                return new Customer();

            string json = await File.ReadAllTextAsync(_customerFile);
            var customer = JsonSerializer.Deserialize<Customer>(json, _options);

            return customer ?? new Customer();
        }
        catch (Exception ex)
        {
            throw new Exception("Error loading customer data.", ex);
        }
    }
}