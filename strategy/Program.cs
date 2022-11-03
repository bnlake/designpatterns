using strategy.Classes;

public static class Program
{
    public static int Main(string[] args)
    {
        List<Content> dataset = new List<Content>() {
            new Content() { Title= "What is Acute Bronchitis?", SNOMED = "10509002", ICD10 = "Acute Bronchitis"},
            new Content() { Title= "Your heart is at risk", SNOMED = "38341003", ICD10 = "Hypertension"},
            new Content() { Title= "Causes of Sinusitis", SNOMED = "444814009", ICD10 = "Viral Sinusitis"}
        };

        string searchedTerm = ReadSearchString() ?? "";

        SearchController controller = new SearchController(dataset);

        // First search with never specifying a search strategy (We're protecting ourselves by using the Null pattern)
        WriteSearchResult(controller.Search(searchedTerm));

        // Now let's try searching with the other strategies
        controller.SetStrategy(new SNOMEDSearchStrategy());
        WriteSearchResult(controller.Search(searchedTerm));

        controller.SetStrategy(new ICD10SearchStrategy());
        WriteSearchResult(controller.Search(searchedTerm));

        controller.SetStrategy(new TitleSearchStrategy());
        WriteSearchResult(controller.Search(searchedTerm));

        Console.ReadKey();
        return 0;
    }

    public static string? ReadSearchString()
    {
        Console.Write("Enter search term: ");
        return Console.ReadLine();
    }

    public static void WriteSearchResult(Content? content)
    {
        if (content is null) Console.WriteLine("No match was found");
        else Console.WriteLine($"Found content titled: {content.Title}");
        Console.WriteLine();
    }
}