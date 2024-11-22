namespace VLG_BaiTapBuoi05.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }

        // Mối quan hệ một-nhiều với UserRole
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
