using Microsoft.Extensions.Hosting;

namespace VLG_BaiTapBuoi05.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; } // Parent category (cha) nếu có
        public Category ParentCategory { get; set; } // Quan hệ cha-con với Category

        public ICollection<Category> SubCategories { get; set; } // Danh sách con của Category
        public ICollection<Post> Posts { get; set; } // Quan hệ với bài viết
    }
}
