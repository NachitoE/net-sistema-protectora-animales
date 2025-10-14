using Domain;
using DTOs;
using Helpers;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class AdoptionsService
    {
        public AdoptionDTO Add(AdoptionRequestDTO adoptionReqDTO)
        {
            var repo = new AdoptionRepository();
            var adoption = new Adoption(
                Guid.NewGuid().ToString(),
                adoptionReqDTO.AnimalId,
                adoptionReqDTO.UserId,
                adoptionReqDTO.AdoptionRequestDate ?? DateTime.Now,
                AdoptionStateEn.Pendiente,
                adoptionReqDTO.Description
            );
            repo.Add(adoption);
            return adoption.ToDTO();
        }

        public AdoptionDTO? Get(string id)
        {
            var repo = new AdoptionRepository();
            var adoption = repo.Get(id);
            return adoption?.ToDTO();
        }

        public List<AdoptionDTO> GetAll()
        {
            var repo = new AdoptionRepository();
            return repo.GetAll().Select(a => a.ToDTO()).ToList();
        }

        public bool Update(string id, AdoptionDTO dto)
        {
            var repo = new AdoptionRepository();
            var adoption = repo.Get(id);
            if (adoption == null) return false;
            adoption.AnimalId = dto.AnimalId;
            adoption.UserId = dto.UserId;
            adoption.AdoptionRequestDate = dto.AdoptionRequestDate;
            adoption.AdoptionResponseDate = dto.AdoptionResponseDate;
            adoption.State = Enum.TryParse<AdoptionStateEn>(dto.State, out var state) ? state : adoption.State;
            adoption.Description = dto.Description;
            return repo.Update(adoption);
        }

        public bool Delete(string id)
        {
            var repo = new AdoptionRepository();
            return repo.Delete(id);
        }
    }
}