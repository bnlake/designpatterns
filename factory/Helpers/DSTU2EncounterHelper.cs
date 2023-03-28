using factory.Interfaces;

namespace factory.Helpers
{
    [EncounterHelper(FhirVersion.DSTU2)]
    internal class DSTU2EncounterHelper : IEncounterHelper
    {
        public string EncounterId => "DSTU2 - EncounterId: 1231";
    }
}
