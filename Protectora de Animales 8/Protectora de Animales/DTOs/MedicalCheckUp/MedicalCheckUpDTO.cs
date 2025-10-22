using System;

namespace DTOs
{
    public class MedicalCheckUpDTO
    {
        public string Id { get; set; }
        public DateTime CheckUpDate { get; set; }
        public string Observation { get; set; }
        public string AnimalId { get; set; }
    }
}
