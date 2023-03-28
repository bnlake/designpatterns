using factory.Interfaces;

namespace factory.Helpers
{
    internal class R4EncounterHelper : IEncounterHelper
    {
        public string EncounterId => Guid.NewGuid().ToString();
    }
}
