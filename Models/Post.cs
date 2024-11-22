namespace VLG_BaiTapBuoi05.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Quan hệ với Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
