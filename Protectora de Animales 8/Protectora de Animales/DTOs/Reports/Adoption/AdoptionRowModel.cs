namespace DTOs.Reports
{
    public class AdoptionRowModel
    {
        public string AnimalName { get; set; }
        public string AdopterUserName { get; set; }
        public string AdoptionRequestDate { get; set; } // formatted date string
        public string? AdoptionResponseDate { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
    }
}
