using Xunit;
using BurgerOrdering.App.Models;
using System.Collections.Generic;

namespace BurgerOrdering.Tests;

public class OrderTests
{
    [Fact]
    public void Burger_BasePrice_IsCorrect()
    {
        var burger = new Burger { Protein = "Beef" };
        Assert.Equal(6, burger.GetTotalPrice());
    }

    [Fact]
    public void Burger_SteakPrice_IsHigher()
    {
        var burger = new Burger { Protein = "Steak" };
        Assert.Equal(8, burger.GetTotalPrice());
    }

    [Fact]
    public void Burger_AddOns_IncreasePrice()
    {
        var burger = new Burger();
        burger.AddOnPrices["Bacon"] = 2;
        burger.AddOnPrices["Onions"] = 0.5;

        Assert.Equal(2.5, burger.GetTotalPrice());
    }

    [Fact]
    public void Burger_Cheese_AddsPrice()
    {
        var burger = new Burger { Cheese = "Swiss" };
        Assert.Equal(1.5, burger.GetTotalPrice());
    }

    [Fact]
    public void Burger_Sauce_AddsPrice()
    {
        var burger = new Burger { Sauce = "Special" };
        Assert.Equal(1.5, burger.GetTotalPrice());
    }

    [Fact]
    public void Burger_PrepTime_Default()
    {
        var burger = new Burger();
        Assert.Equal(5, burger.GetPrepTime());
    }

    [Fact]
    public void Burger_PrepTime_Chicken_IsFaster()
    {
        var burger = new Burger { Protein = "Chicken" };
        Assert.Equal(8, burger.GetPrepTime());
    }

    [Fact]
    public void Order_TotalPrice_IncludesBurger()
    {
        var order = new Order();
        order.Burger = new Burger { Protein = "Beef" };

        Assert.Equal(6, order.GetTotalPrice());
    }

    [Fact]
    public void Order_TeacherDiscount_Applies()
    {
        var order = new Order();
        order.Burger = new Burger { Protein = "Beef" };

        var final = order.GetFinalPrice(true);

        Assert.Equal(5.4, final, 1);
    }

    [Fact]
    public void Order_NoDiscount_ForNonTeacher()
    {
        var order = new Order();
        order.Burger = new Burger { Protein = "Beef" };

        var final = order.GetFinalPrice(false);

        Assert.Equal(6, final);
    }

    [Fact]
    public void Order_PrepTime_AddsBurgerTime()
    {
        var order = new Order();
        order.Burger = new Burger { Protein = "Steak" };

        Assert.True(order.GetTotalPrepTime() >= 10);
    }
}