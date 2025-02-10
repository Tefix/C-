using System;

class Program
{
    static void Main()
    {
        // Sequence of amounts to exchange
        int[] amounts = { 18, 19, 37, 99 };

        foreach (int amount in amounts)
        {
            Console.WriteLine($"Amount: {amount} cents");
            GetMinimumCoins(amount);
            Console.WriteLine();
        }
    }

    static void GetMinimumCoins(int amount)
    {
        // Available coin denominations
        int[] coins = { 50, 20, 10, 5, 2, 1 };

        for (int i = 0; i < coins.Length; i++)
        {
            int count = amount / coins[i]; // Number of coins of this denomination
            amount %= coins[i]; // Remaining amount

            if (count > 0)
            {
                Console.WriteLine($"{count} {GetCoinName(count, coins[i])}");
            }
        }
    }

    // Method for correct wording
    static string GetCoinName(int count, int value)
    {
        if (value == 1)
        {
            if (count == 1) return "coin of 1 cent";
            return "coins of 1 cent";
        }
        else if (value == 2)
        {
            if (count == 1) return "coin of 2 cents";
            return "coins of 2 cents";
        }
        else if (value == 5)
        {
            if (count == 1) return "coin of 5 cents";
            return "coins of 5 cents";
        }
        else if (value == 10)
        {
            if (count == 1) return "coin of 10 cents";
            return "coins of 10 cents";
        }
        else if (value == 20)
        {
            if (count == 1) return "coin of 20 cents";
            return "coins of 20 cents";
        }
        else if (value == 50)
        {
            if (count == 1) return "coin of 50 cents";
            return "coins of 50 cents";
        }

        return "coins";
    }
}
