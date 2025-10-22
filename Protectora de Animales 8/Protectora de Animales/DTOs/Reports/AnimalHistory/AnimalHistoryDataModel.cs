namespace DTOs.Reports.AnimalHistory
{
    public class AnimalHistoryDataModel
    {
        public string Header { get; set; }
        public string Footer { get; set; }
        public List<AnimalHistoryRowModel> AnimalHistories { get; set; }
    }
}
