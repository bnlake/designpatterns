using factory.Helpers;
using factory.Interfaces;

namespace factory
{
    internal static class EncounterHelperFactory
    {
        public static IEncounterHelper Create(FhirVersion fhirVersion)
        {
            switch (fhirVersion)
            {
                case FhirVersion.None: throw new NotImplementedException("No FHIR version was identified");
                case FhirVersion.DSTU2: return new DSTU2EncounterHelper();
                case FhirVersion.STU3: return new STU3EncounterHelper();
                case FhirVersion.R4: return new R4EncounterHelper();
                default: throw new NotImplementedException("Unknown fhir version selected");
            }
        }
    }
}
