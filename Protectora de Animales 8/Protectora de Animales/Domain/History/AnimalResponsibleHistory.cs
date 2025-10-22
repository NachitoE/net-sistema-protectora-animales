namespace Domain.History
{
    public class AnimalResponsibleHistory
    {
        public string Id
        {
            get => _id;
            set => _id = value;
        }
        private string _id;
        public DateTime AssignedDate
        {
            get => _assignedDate;
            set => _assignedDate = value;
        }
        private DateTime _assignedDate;
        public string ResponsibleId
        {
            get => _responsibleId;
            set => _responsibleId = value;
        }
        private string _responsibleId;
        public User Responsible
        {
            get => _responsible;
            set => _responsible = value;
        }
        private User _responsible;
        public string AnimalId
        {
            get => _animalId;
            set => _animalId = value;
        }
        private string _animalId;
        public Animal Animal
        {
            get => _animal;
            set => _animal = value;
        }
        private Animal _animal;

        public AnimalResponsibleHistory
        (
            string id,
            DateTime assignedDate,
            string responsibleId,
            string animalId
        )
        {
            Id = id;
            AssignedDate = assignedDate;
            ResponsibleId = responsibleId;
            AnimalId = animalId;
        }
    }
}
