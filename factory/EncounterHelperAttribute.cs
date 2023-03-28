namespace factory
{
    internal class EncounterHelperAttribute : Attribute
    {
        public FhirVersion FhirVersion { get; set; }
        public EncounterHelperAttribute(FhirVersion fhirVersion) { this.FhirVersion = fhirVersion; }
    }
}
