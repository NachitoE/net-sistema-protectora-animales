using DTOs.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Reports.AnimalHistory
{
    public class AnimalResponsibleHistoryHandler : IAnimalHistoryEvent
    {
        private readonly UserDTO _responsibleData;
        private readonly AnimalResponsibleHistoryDTO _responsibleHistoryDTO;
        public string Description => $"Encargado al {_responsibleData.UserType} {_responsibleData.Name} {_responsibleData.SurName}";
        public string Date => _responsibleHistoryDTO.AssignedDate.ToString("dd/MM/yyyy HH:mm:ss");

        public AnimalResponsibleHistoryHandler(UserDTO animalResponsibleData, AnimalResponsibleHistoryDTO responsibleHistoryDTO)
        {
            _responsibleData = animalResponsibleData;
            _responsibleHistoryDTO = responsibleHistoryDTO;
        }
    }
}
