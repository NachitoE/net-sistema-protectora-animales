namespace DTOs
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string DNI { get; set; }
        public string UserType { get; set; }
        public string UserName { get; set; }
        // non including password for security
    }
}
