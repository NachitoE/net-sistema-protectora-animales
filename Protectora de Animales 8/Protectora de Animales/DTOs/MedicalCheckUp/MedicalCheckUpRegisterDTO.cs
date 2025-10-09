namespace DTOs
{
    public class MedicalCheckUpRegisterDTO
    {
        public string UserId { get; set; }
        public DateTime CheckUpDate { get; set; }
        public string Observation { get; set; }
        public string AnimalId { get; set; }
    }
}
