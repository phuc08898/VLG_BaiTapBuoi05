﻿using Microsoft.EntityFrameworkCore;
using VLG_BaiTapBuoi05.Models;

namespace VLG_BaiTapBuoi05.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Các DbSet tương ứng với các bảng trong cơ sở dữ liệu
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }

        // Cấu hình các mối quan hệ trong phương thức OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mối quan hệ giữa User và UserRole
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            // Mối quan hệ giữa Category và Post
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Category)  // Post có một Category
                .WithMany(c => c.Posts)   // Category có nhiều Post
                .HasForeignKey(p => p.CategoryId);  // Khóa ngoại

            // Mối quan hệ giữa Category và SubCategory (cha-con)
            modelBuilder.Entity<Category>()
                .HasMany(c => c.SubCategories)  // Category có nhiều SubCategories (danh mục con)
                .WithOne(c => c.ParentCategory) // Mỗi SubCategory có một danh mục cha
                .HasForeignKey(c => c.ParentId) // Khóa ngoại trỏ đến ParentId
                .OnDelete(DeleteBehavior.Restrict);  // Không xóa tự động SubCategory khi xóa Category cha

            base.OnModelCreating(modelBuilder);
        }
    }
}
