namespace WarehouseManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        private string _passwordHash;
        public UserRole Role { get; set; }
        public string FullName { get; set; }

        public User(int id, string login, string password, UserRole role, string fullName)
        {
            Id = id;
            Login = login;
            _passwordHash = HashPassword(password);
            Role = role;
            FullName = fullName;
        }

        public bool Authenticate(string password)
            => _passwordHash == HashPassword(password);

        private string HashPassword(string password)
            => Convert.ToBase64String(
                System.Security.Cryptography.SHA256
                    .HashData(System.Text.Encoding.UTF8.GetBytes(password)));
    }
}