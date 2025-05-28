using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;

class Program
{
    static void Main()
    {
        // Створення OrderedDictionary
        OrderedDictionary accounts = new OrderedDictionary();

        // Додавання елементів (рахунок → сума)
        accounts.Add("AccountA", 1500.0);
        accounts.Add("AccountB", 3200.5);
        accounts.Add("AccountC", 980.75);
        accounts.Add("AccountD", 4000.0);

        Console.WriteLine("Список рахунків:");
        foreach (DictionaryEntry entry in accounts)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Порівняння значень: знаходимо найбільший рахунок
        var maxEntry = accounts.Cast<DictionaryEntry>()
                               .OrderByDescending(e => (double)e.Value)
                               .First();

        Console.WriteLine($"\nМаксимальна сума: {maxEntry.Key} → {maxEntry.Value}");

        // Знаходимо мінімальне значення
        var minEntry = accounts.Cast<DictionaryEntry>()
                               .OrderBy(e => (double)e.Value)
                               .First();

        Console.WriteLine($"Мінімальна сума: {minEntry.Key} → {minEntry.Value}");

        // Порівняння двох конкретних рахунків
        double valueA = (double)accounts["AccountA"];
        double valueB = (double)accounts["AccountB"];

        Console.WriteLine($"\nПорівняння AccountA та AccountB:");
        if (valueA > valueB)
            Console.WriteLine("AccountA має більшу суму.");
        else if (valueA < valueB)
            Console.WriteLine("AccountB має більшу суму.");
        else
            Console.WriteLine("Суми однакові.");
    }
}

