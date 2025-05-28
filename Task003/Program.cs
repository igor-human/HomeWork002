using System;
using System.Collections.Generic;

namespace AccountCollectionsDemo
{
    // Варіант 3: Власна структура
    struct Account
    {
        public int Id;
        public double Balance;

        public Account(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Dictionary<int, double> ===");
            Dictionary<int, double> dictAccounts = new Dictionary<int, double>();
            dictAccounts.Add(101, 2500.75);
            dictAccounts.Add(102, 10999.50);

            foreach (var pair in dictAccounts)
                Console.WriteLine($"Рахунок: {pair.Key}, Баланс: {pair.Value}");

            Console.WriteLine("\n=== List<KeyValuePair<int, double>> ===");
            List<KeyValuePair<int, double>> kvpAccounts = new List<KeyValuePair<int, double>>
            {
                new KeyValuePair<int, double>(103, 3333.33),
                new KeyValuePair<int, double>(104, 4444.44)
            };

            foreach (var pair in kvpAccounts)
                Console.WriteLine($"Рахунок: {pair.Key}, Баланс: {pair.Value}");

            Console.WriteLine("\n=== List<Account> (структура) ===");
            List<Account> structAccounts = new List<Account>
            {
                new Account(105, 5555.55),
                new Account(106, 6666.66)
            };

            foreach (var acc in structAccounts)
                Console.WriteLine($"Рахунок: {acc.Id}, Баланс: {acc.Balance}");

            Console.WriteLine("\n=== List<Tuple<int, double>> ===");
            List<Tuple<int, double>> tupleAccounts = new List<Tuple<int, double>>
            {
                new Tuple<int, double>(107, 7777.77),
                new Tuple<int, double>(108, 8888.88)
            };

            foreach (var acc in tupleAccounts)
                Console.WriteLine($"Рахунок: {acc.Item1}, Баланс: {acc.Item2}");
        }
    }
}
