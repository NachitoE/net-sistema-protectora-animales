using System;

namespace DTOs
{
    public class AdoptionDTO
    {
        public string Id { get; set; }
        public string AnimalId { get; set; }
        public string UserId { get; set; }
        public DateTime AdoptionRequestDate { get; set; }
        public DateTime? AdoptionResponseDate { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
    }
}
