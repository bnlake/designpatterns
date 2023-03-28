using factory.Interfaces;

namespace factory.Helpers
{
    [EncounterHelper(FhirVersion.STU3)]
    internal class STU3EncounterHelper : IEncounterHelper
    {
        public string EncounterId => "STU3 - EncounterId: 123112-31abv";
    }
}
