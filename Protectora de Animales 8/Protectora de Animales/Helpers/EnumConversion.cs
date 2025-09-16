using Domain;
using static Domain.Animal;

namespace Helpers
    {
        public static class EnumConversion
        {
            public static string SpeciesToString(SpeciesEn species) => species.ToString();

            public static SpeciesEn StringToSpecies(string species)
            {
                if (Enum.TryParse<SpeciesEn>(species, true, out var result))
                    return result;
                throw new ArgumentException($"Invalid species: {species}");
            }

     
            public static string AnimalStateToString(AnimalStateEn state) => state.ToString();

            public static AnimalStateEn StringToAnimalState(string state)
            {
                if (Enum.TryParse<AnimalStateEn>(state, true, out var result))
                    return result;
                throw new ArgumentException($"Invalid animal state: {state}");
            }

        }
}


