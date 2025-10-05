using Domain;
using DTOs;
using Helpers;
using Infrastructure.Data;

namespace Services
{
    public class SightingsService
    {
        
        public SightingDTO Add(SightingRegisterDTO sightingRegDTO)
        {
            var sightingRepository = new SightingRepository();

            
            Sighting createdSighting = new Sighting(
                Guid.NewGuid().ToString(),
                sightingRegDTO.SightingAddressName,
                sightingRegDTO.SightingAddressNumber,
                sightingRegDTO.SightingDateTime,
                sightingRegDTO.SightingDescription,
                Sighting.SightingState.Nuevo 
            );

            
            sightingRepository.Add(createdSighting);

            
            return createdSighting.ToDTO();
        }

        
        public SightingDTO? Get(string id)
        {
            var sightingRepository = new SightingRepository();
            Sighting? sighting = sightingRepository.Get(id);

            return sighting?.ToDTO();
        }

        
        public List<SightingDTO> GetAll()
        {
            var sightingRepository = new SightingRepository();
            var sightingsDomain = sightingRepository.GetAll();

            return sightingsDomain.Select(s => s.ToDTO()).ToList();
        }

        
        public bool Delete(string id)
        {
            var sightingRepository = new SightingRepository();
            return sightingRepository.Delete(id);
        }

        
        public SightingDTO? Update(SightingDTO sightingDTO)
        {
            var sightingRepository = new SightingRepository();

            
            Sighting.SightingState stateEnum = Enum.Parse<Sighting.SightingState>(sightingDTO.SightingState);

            Sighting sightingToUpdate = new Sighting(
                sightingDTO.Id,
                sightingDTO.SightingAdressName,
                sightingDTO.SightingAdressNumber,
                sightingDTO.SightingDatetime,
                sightingDTO.SightingDescription,
                stateEnum
            );

            bool updated = sightingRepository.Update(sightingToUpdate);
            return updated ? sightingToUpdate.ToDTO() : null;
        }

        /// <summary>
        /// Deshabilita, si es posible, el Avistamiento
        /// </summary>
        /// <param name="id"></param>
        /// <returns>SightingBaseResponseDTO con un mensaje aclarando en caso de Success False</returns>
        public SightingBaseResponseDTO Disable(string id)
        {
            SightingDTO sightingDTO = Get(id);
            if (sightingDTO.SightingState != EnumConversion.SightingStateToString(Sighting.SightingState.Nuevo))
            {
                return new SightingBaseResponseDTO()
                {
                    Message = "Solo se pueden eliminar avistamientos con estado 'Nuevo'.",
                    Success = false
                };
            }
            sightingDTO.SightingState = EnumConversion.SightingStateToString(Sighting.SightingState.Eliminado);
            var newSighting = Update(sightingDTO);
            return new SightingBaseResponseDTO()
            {
                Sighting = newSighting,
                Success = true
            };
        }
    }
}
