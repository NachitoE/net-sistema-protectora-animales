using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Reports.AnimalHistory
{
    public class AnimalMedicalInfoHandler : IAnimalHistoryEvent
    {
        private MedicalCheckUpDTO _medicalData;
        public string Description => _medicalData.Observation;
        public string Date => _medicalData.CheckUpDate.ToString("dd/MM/yyyy HH:mm:ss");
        public AnimalMedicalInfoHandler(MedicalCheckUpDTO medicalData)
        {
            _medicalData = medicalData;
        }
    }
}
