namespace VLG_BaiTapBuoi05.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Mối quan hệ một-nhiều với UserRole
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
