using System;

namespace DTOs
{
    public class AdoptionDTO
    {
        public string Id { get; set; }
        public string AnimalId { get; set; }
        public string UserId { get; set; }
        public DateTime AdoptionDate { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
