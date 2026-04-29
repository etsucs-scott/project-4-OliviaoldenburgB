# Burger Ordering Application

## Overview

This project is a multi-page burger ordering system built using ASP.NET Core Blazor.  
It allows users to customize a burger, select sides and desserts, and view a final receipt.  
The application demonstrates component-based design, state management, and interactive UI behavior.

---

## Features

- Start an order from the home page  
- Indicate whether the customer is a teacher  
- Customize a burger (protein, cheese, sauce, add-ons)  
- Select multiple side items  
- Choose a dessert or skip  
- View a receipt with total price and estimated preparation time  
- Shared application state across all pages  

---

## Technologies Used

- ASP.NET Core Blazor (Interactive Server)  
- C#  
- Razor Components  
- .NET 8/9  

---

## Project Structure

BurgerOrdering.App  
Contains the data models:
- Burger  
- Customer  
- Order  
- Sides  
- Dessert  

BurgerOrdering.UI  
Contains the user interface:
- Components  
  - Pages (Home, Teacher, Burger, Sides, Dessert, Receipt)  
  - Layout (MainLayout, NavMenu)  
- Services  
  - AppState (shared state across pages)  

---

## How to Run

1. Open the project in Visual Studio Code  
2. Open a terminal in the project folder  
3. Run the following command:

   dotnet run --project BurgerOrdering.UI

4. Open a browser and go to:

   http://localhost:5116  

---

## How It Works

The application uses a shared service called AppState to store the current order.  
Each page updates part of the order and navigates to the next step.

Flow:  
Home → Teacher → Burger → Sides → Dessert → Receipt  

---

## Key Concepts Demonstrated

- Razor components and routing  
- Event handling with @onclick and @onchange  
- Dependency injection  
- Shared state using services  
- Navigation between pages  

---

## Notes

- The project uses Blazor Interactive Server mode for real-time UI updates.  
- All selections are stored in memory for the duration of the session.  
- No database is required.  

