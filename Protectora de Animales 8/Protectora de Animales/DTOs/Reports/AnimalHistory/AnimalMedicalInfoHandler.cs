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
        public DateTime Date => _medicalData.CheckUpDate;
        public AnimalMedicalInfoHandler(MedicalCheckUpDTO medicalData)
        {
            _medicalData = medicalData;
        }
    }
}
