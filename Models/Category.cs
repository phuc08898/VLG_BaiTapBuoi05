namespace VLG_BaiTapBuoi05.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Tham chiếu đến danh mục cha
        public int? ParentId { get; set; } // Nếu là danh mục cha thì null, nếu không thì có giá trị

        // Quan hệ với danh mục cha
        public Category ParentCategory { get; set; }

        // Danh sách danh mục con
        public ICollection<Category> SubCategories { get; set; }

        // Quan hệ với bài viết
        public ICollection<Post> Posts { get; set; }
    }
}
