using static Domain.Animal;
using static Domain.User;

namespace Helpers
{
    public static class EnumValues
    {
        public static List<string> GetSpecies()
        {
            return Enum.GetNames(typeof(SpeciesEn)).ToList();
        }
        public static List<string> GetAnimalStates()
        {
            return Enum.GetNames(typeof(AnimalStateEn)).ToList();
        }
    }
}
