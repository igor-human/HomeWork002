using System;
using System.Collections.Generic;
using System.Linq;

class PurchaseTracker
{
    private Dictionary<string, List<string>> buyerToCategories = new();
    private Dictionary<string, List<string>> categoryToBuyers = new();

    // Додати покупця і категорію товару
    public void AddPurchase(string buyer, string category)
    {
        // Додаємо до словника покупець → категорії
        if (!buyerToCategories.ContainsKey(buyer))
            buyerToCategories[buyer] = new List<string>();

        if (!buyerToCategories[buyer].Contains(category))
            buyerToCategories[buyer].Add(category);

        // Додаємо до словника категорія → покупці
        if (!categoryToBuyers.ContainsKey(category))
            categoryToBuyers[category] = new List<string>();

        if (!categoryToBuyers[category].Contains(buyer))
            categoryToBuyers[category].Add(buyer);
    }

    // Отримати категорії товарів, які купив покупець
    public List<string> GetCategoriesByBuyer(string buyer)
    {
        return buyerToCategories.ContainsKey(buyer) ? buyerToCategories[buyer] : new List<string>();
    }

    // Отримати покупців, які купили товари певної категорії
    public List<string> GetBuyersByCategory(string category)
    {
        return categoryToBuyers.ContainsKey(category) ? categoryToBuyers[category] : new List<string>();
    }
}

class Program
{
    static void Main()
    {
        var tracker = new PurchaseTracker();

        // Додаємо покупки
        tracker.AddPurchase("Олена", "Електроніка");
        tracker.AddPurchase("Іван", "Книги");
        tracker.AddPurchase("Олена", "Одяг");
        tracker.AddPurchase("Марія", "Книги");
        tracker.AddPurchase("Іван", "Електроніка");

        // Приклади запитів
        Console.WriteLine("Категорії, які купила Олена:");
        foreach (var category in tracker.GetCategoriesByBuyer("Олена"))
        {
            Console.WriteLine("- " + category);
        }

        Console.WriteLine("\nПокупці, які купили Книги:");
        foreach (var buyer in tracker.GetBuyersByCategory("Книги"))
        {
            Console.WriteLine("- " + buyer);
        }
    }
}
