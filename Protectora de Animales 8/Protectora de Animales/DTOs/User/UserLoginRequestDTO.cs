namespace DTOs
{
    public class UserLoginRequestDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserLoginRequestDTO(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
