using factory.Interfaces;

namespace factory.Helpers
{
    internal class R4EncounterHelper : IEncounterHelper
    {
        public string EncounterId => new Guid().ToString();
    }
}
