using Domain;
using DTOs;
using DTOs.Adoption;
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
                adoptionReqDTO.Description ?? ""
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

        public List<AdoptionDTO> GetPendingAdoptionsByAnimalId(string animalId)
        {
            var repo = new AdoptionRepository();
            return repo.GetAll()
                .Where(a => a.AnimalId == animalId && a.State == AdoptionStateEn.Pendiente)
                .Select(a => a.ToDTO())
                .ToList();
        }

        /// <summary>
        /// returns rejected adoptions
        /// </summary>
        /// <param name="animalId"></param>
        /// <returns></returns>
        public List<AdoptionDTO> RejectPendingAdoptionsByAnimalId(string animalId, string? description = null)
        {
            var repo = new AdoptionRepository();
            List<Adoption> animalAdoptions = repo.GetAll()
                .Where(a => a.AnimalId == animalId && a.State == AdoptionStateEn.Pendiente)
                .ToList();
            foreach(var adoption in animalAdoptions)
            {
                if (!string.IsNullOrEmpty(description))
                {
                    adoption.Description = description;
                }
                adoption.AdoptionResponseDate = DateTime.Now;
                adoption.State = AdoptionStateEn.Rechazada;
                repo.Update(adoption);
            }
            return animalAdoptions.Select(a => a.ToDTO()).ToList();
        }

        public AdoptionDTO? ApproveOrRejectPendingAdoption(string id, AdoptionRejectApproveDTO changeDTO)
        {
            var repo = new AdoptionRepository();
            var adoptionDomain = repo.Get(id);
            if (adoptionDomain == null)
            {
                throw new NotFoundException("Adopción no existente");
            }
            if (adoptionDomain.State != AdoptionStateEn.Pendiente)
            {
                throw new DomainException("Solo se pueden aprobar o rechazar adopciones en estado pendiente");
            }
            AnimalsService animalService = new AnimalsService();
            AnimalDTO animal = animalService.Get(adoptionDomain.AnimalId) ?? 
                throw new DomainException("Animal no existente");

            //TODO: quizás habria que validar si el animal ya está adoptado??
            //NACHO: Igual es un caso muy extremo ya que al animal ser adoptado se rechazan todas las demás adopciones pendientes, por lo que en teoría no deberiamos llegar a ese punto
            adoptionDomain.AdoptionResponseDate = changeDTO.AdoptionResponseDate ?? DateTime.Now;
            AdoptionStateEn newState = changeDTO.Approved ? AdoptionStateEn.Aprobada : AdoptionStateEn.Rechazada;
            adoptionDomain.State = newState;
            adoptionDomain.Description = changeDTO.Description ?? adoptionDomain.Description;
            repo.Update(adoptionDomain);
            //asignar adoptante como responsable de animal, se rechazan las demás adopciones pendientes de ese animal
            if(newState == AdoptionStateEn.Rechazada) return adoptionDomain.ToDTO();
            animalService.AssignResponsible(animal.Id, adoptionDomain.UserId);
            
            
            return adoptionDomain.ToDTO();


        }

        public List<AdoptionDTO> GetAdoptionsByUserId(string userId)
        {
            var repo = new AdoptionRepository();
            return repo.GetAll()
                .Where(a => a.UserId == userId)
                .Select(a => a.ToDTO())
                .ToList();
        }
    }
}