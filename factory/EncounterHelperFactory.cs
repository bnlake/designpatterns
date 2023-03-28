using factory.Interfaces;
using System.Reflection;

namespace factory
{
    internal static class EncounterHelperFactory
    {
        private static readonly IDictionary<FhirVersion, Type> Helpers = new Dictionary<FhirVersion, Type>();

        public static IEncounterHelper Create(FhirVersion fhirVersion)
        {
            if (Helpers.TryGetValue(fhirVersion, out var helper))
            {
                return Activator.CreateInstance(helper) as IEncounterHelper;
            }
            else throw new NotImplementedException("Unknown fhir version selected");
        }

        public static void RegisterHelpers()
        {
            // Find all classes that have the EncounterHelper attribute assigned to them
            var foundHelpers = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetCustomAttributes<EncounterHelperAttribute>().Any());

            foreach (var helper in foundHelpers)
            {
                // Get the fhir version that the helper was registered with
                var attribute = helper.GetCustomAttribute<EncounterHelperAttribute>();
                var fhirVersion = attribute.FhirVersion;

                Helpers.Add(fhirVersion, helper);
            }
        }
    }
}
