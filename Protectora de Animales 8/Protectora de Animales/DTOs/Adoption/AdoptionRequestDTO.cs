namespace DTOs
{
    public class AdoptionRequestDTO
    {
        public string AnimalId { get; set; }
        public string UserId { get; set; } // will be calculated on API from JWT
        public DateTime? AdoptionRequestDate { get; set; }
        public string Description { get; set; }
    }
}
