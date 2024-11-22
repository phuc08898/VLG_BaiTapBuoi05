
using VLG_BaiTapBuoi05.Models;

namespace VLG_BaiTapBuoi05.Data
{
    public static class MockData
    {
        // Danh sách người dùng giả lập
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                Username = "admin",
                PasswordHash = "admin123",
                Email = "admin@example.com",
                CreatedAt = System.DateTime.UtcNow,
                LastLogin = System.DateTime.UtcNow
            },
            new User
            {
                Id = 2,
                Username = "user1",
                PasswordHash = "user123",  
                Email = "user1@example.com",
                CreatedAt = System.DateTime.UtcNow,
                LastLogin = System.DateTime.UtcNow
            }
        };
    }
}
