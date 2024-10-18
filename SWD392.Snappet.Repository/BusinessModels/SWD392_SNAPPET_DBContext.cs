﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SWD392.Snappet.Repository.BusinessModels;

public partial class SWD392_SNAPPET_DBContext : DbContext
{
    public SWD392_SNAPPET_DBContext()
    {
    }

    public SWD392_SNAPPET_DBContext(DbContextOptions<SWD392_SNAPPET_DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminAction> AdminActions { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<Emotion> Emotions { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Pet> Pets { get; set; }

    public virtual DbSet<PetCategory> PetCategories { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PostEmotion> PostEmotions { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-8OR5KK86;Initial Catalog=SWD392_SNAPPET_DB;Persist Security Info=True;User ID=sa;Password=123456");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PK__Admin_Ac__FFE3F4B9F7334F80");

            entity.ToTable("Admin_Actions");

            entity.Property(e => e.ActionId).HasColumnName("ActionID");
            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.EntityType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");

            entity.HasOne(d => d.Admin).WithMany(p => p.AdminActions)
                .HasForeignKey(d => d.AdminId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admin_Act__Admin__4F7CD00D");
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Admin_Us__719FE4E8055A5B21");

            entity.ToTable("Admin_Users");

            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Emotion>(entity =>
        {
            entity.HasKey(e => e.EmotionId).HasName("PK__Emotion__25B02E11A8341E76");

            entity.ToTable("Emotion");

            entity.Property(e => e.EmotionId).HasColumnName("EmotionID");
            entity.Property(e => e.TagName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Tag_name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAFF99BC4B6");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Details)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Orders__UserID__48CFD27E");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("PK__Package__322035EC0DA4CBB4");

            entity.ToTable("Package");

            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.PackageName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Packages)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Package__UserID__4CA06362");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__9B556A5883B34D99");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");

            entity.HasOne(d => d.Order).WithMany(p => p.Payments)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Payment__OrderID__5CD6CB2B");
        });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.PetId).HasName("PK__Pets__48E5380266CCD8AC");

            entity.Property(e => e.PetId).HasColumnName("PetID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProfilePhotoUrl)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ProfilePhotoURL");

            entity.HasOne(d => d.Category).WithMany(p => p.Pets)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pets__CategoryID__4222D4EF");

            entity.HasOne(d => d.Owner).WithMany(p => p.Pets)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pets__OwnerID__412EB0B6");
        });

        modelBuilder.Entity<PetCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Pet_Cate__19093A2BA64F4FD0");

            entity.ToTable("Pet_Category");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Photo).HasMaxLength(255);
        });

        modelBuilder.Entity<Photo>(entity =>
        {
            entity.HasKey(e => e.PhotoId).HasName("PK__Photos__21B7B582C88CB9EE");

            entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.PetId).HasColumnName("PetID");
            entity.Property(e => e.PhotoUrl)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PhotoURL");
            entity.Property(e => e.Tags)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Pet).WithMany(p => p.Photos)
                .HasForeignKey(d => d.PetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Photos__PetID__44FF419A");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__Posts__AA126038CC001260");

            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.Content)
                .IsRequired()
                .HasColumnType("text");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            entity.Property(e => e.PostEmotionId).HasColumnName("Post_EmotionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Photo).WithMany(p => p.Posts)
                .HasForeignKey(d => d.PhotoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Posts__PhotoID__59063A47");

            entity.HasOne(d => d.PostEmotion).WithMany(p => p.Posts)
                .HasForeignKey(d => d.PostEmotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Posts__Post_Emot__59FA5E80");

            entity.HasOne(d => d.User).WithMany(p => p.Posts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Posts__UserID__5812160E");
        });

        modelBuilder.Entity<PostEmotion>(entity =>
        {
            entity.HasKey(e => e.PostEmotionId).HasName("PK__Post_Emo__E305365C25025E94");

            entity.ToTable("Post_Emotion");

            entity.Property(e => e.PostEmotionId).HasColumnName("Post_EmotionID");
            entity.Property(e => e.EmotionId).HasColumnName("EmotionID");

            entity.HasOne(d => d.Emotion).WithMany(p => p.PostEmotions)
                .HasForeignKey(d => d.EmotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Post_Emot__Emoti__52593CB8");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK__Reports__D5BD48E5305E4670");

            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.GeneratedAt).HasColumnType("datetime");
            entity.Property(e => e.ReportType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.GeneratedByNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.GeneratedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reports__Generat__5535A963");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC0E87B473");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.AccountType)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}