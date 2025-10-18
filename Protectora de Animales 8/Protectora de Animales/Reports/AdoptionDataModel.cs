namespace Reports
{
    public class AdoptionDataModel
    {
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Content { get; set; }
        public List<AdoptionRowModel> Adoptions { get; set; }
    }
}
