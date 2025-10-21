namespace DTOs.Reports.AnimalHistory
{
    public class AnimalHistoryRowModel
    {
        public string AnimalName { get; set; }
        public List<IAnimalHistoryEvent> Events { get; set; }

    }
}
