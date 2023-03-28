using factory.Interfaces;

namespace factory.Helpers
{
    [EncounterHelper(FhirVersion.R4)]
    internal class R4EncounterHelper : IEncounterHelper
    {
        public string EncounterId => Guid.NewGuid().ToString();
    }
}
