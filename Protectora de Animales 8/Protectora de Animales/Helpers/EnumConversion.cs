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
            
            public static string SightingStateToString(Sighting.SightingState state) => state.ToString();
        public static string UserTypeToString(UserType userType) => userType.ToString();
        public static UserType StringToUserType(string userType)
        {
            if (Enum.TryParse<UserType>(userType, true, out var result))
                return result;
            throw new ArgumentException($"Invalid user type: {userType}");
        }

        public static string UserStatusToString(UserStatus state) => state.ToString();
        public static UserStatus StringToUserStatus(string userStatus)
        {
            if (Enum.TryParse<UserStatus>(userStatus, true, out var result))
                return result;
            throw new ArgumentException($"Invalid user status: {userStatus}");
        }
    }
}


