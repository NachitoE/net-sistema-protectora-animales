using System;

namespace DTOs
{
    public class AnimalDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserId { get; set; } = "";
        public string AnimalState { get; set; }
        public string Description { get; set; }
    }
}
