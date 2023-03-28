namespace factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Locate and register all EncounterHelper classes
            EncounterHelperFactory.RegisterHelpers();

            while (true)
            {
                var fhirVersion = PromptForFhirVersion();
                Console.WriteLine($"Selected FHIR Version: {fhirVersion}\n");

                try
                {
                    var helper = EncounterHelperFactory.Create(fhirVersion);
                    Console.WriteLine($"Encounter ID: {helper.EncounterId}");
                }
                catch (NotImplementedException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    Console.WriteLine();
                }
            }

        }

        static FhirVersion PromptForFhirVersion()
        {
            Console.WriteLine("FHIR Versions");
            Console.WriteLine("2. DSTU2");
            Console.WriteLine("3. STU3");
            Console.WriteLine("4. R4");
            Console.WriteLine("Choose your version: ");

            if (Enum.TryParse<FhirVersion>(Console.ReadLine(), out var result))
            {
                return result;
            }
            else return FhirVersion.None;
        }
    }
}