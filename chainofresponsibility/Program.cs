using chainofresponsibility.Handlers;
using chainofresponsibility.Models;

public static class Program
{
    public static async Task<int> Main()
    {
        Console.WriteLine("This application will return a users favorited content");

        IHandler chain = new RedisHandler().SetNext(new SQLDBHandler().SetNext(new NullHandler()));

        while (true)
        {
            Console.WriteLine("Please input the users identifier (i.e. 1): ");

            int input = int.Parse(Console.ReadLine()?.ToString() ?? (-1).ToString());
            if (input < 0) break;
            Console.WriteLine();

            PrintFavorites(await chain.HandleAsync(input));
        }

        return 0;
    }

    private static void PrintFavorites(IEnumerable<Content>? favorites)
    {
        if (favorites is null || favorites.Count() == 0)
        {
            Console.WriteLine("No favorites for user");
            return;
        }

        foreach (Content content in favorites)
        {
            Console.WriteLine(content.ToString());
        }
    }
}