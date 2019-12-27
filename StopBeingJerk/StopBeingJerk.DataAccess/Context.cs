using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StopBeingJerk.Domain.Entities;

namespace StopBeingJerk.DataAccess
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CarBrand> CarBrands { get; set; }
        public virtual DbSet<CarInfoCard> CarInfoCards { get; set; }
        public virtual DbSet<CarModel> CarModels { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<CommentTopicType> CommentTopicTypes { get; set; }
        public virtual DbSet<CommentTopic> CommentTopics { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<PhotoInfoCard> PhotoInfoCards { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<RegistrationNumber> RegistrationNumbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=localhost;initial catalog=StopBeingJerkDb;integrated security=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarBrand>(entity =>
            {
                entity.HasIndex(e => e.BrandName)
                    .HasName("UQ_Brand_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CarInfoCard>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.RegistrationNumberId).HasColumnName("RegistrationNumberID");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.CarInfoCards)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_CarInfoCards_To_Colors");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.CarInfoCards)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_CarInfoCards_To_CarModels");

                entity.HasOne(d => d.RegistrationNumber)
                    .WithMany(p => p.CarInfoCards)
                    .HasForeignKey(d => d.RegistrationNumberId)
                    .HasConstraintName("FK_CarInfoCards_To_RegistrationNumbers");
            });

            modelBuilder.Entity<CarModel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.CarModels)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_CarModels_To_CarBrands");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasIndex(e => e.ColorName)
                    .HasName("UQ_Color_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<CommentTopicType>(entity =>
            {
                entity.HasIndex(e => e.TypeName)
                    .HasName("UQ_TopicType_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<CommentTopic>(entity =>
            {
                entity.HasIndex(e => e.TopicName)
                    .HasName("UQ_Topic_Nmae")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TopicName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TopicTypeId).HasColumnName("TopicTypeID");

                entity.HasOne(d => d.TopicType)
                    .WithMany(p => p.CommentTopics)
                    .HasForeignKey(d => d.TopicTypeId)
                    .HasConstraintName("FK_CommentTopics_To_CommentTopicTypes");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.CommentDescription).IsRequired();

                entity.Property(e => e.CommentTopicId).HasColumnName("CommentTopicID");

                entity.Property(e => e.RegistrationNumberId).HasColumnName("RegistrationNumberID");

                entity.HasOne(d => d.CommentTopic)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CommentTopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_To_CommentTopics");

                entity.HasOne(d => d.RegistrationNumber)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.RegistrationNumberId)
                    .HasConstraintName("FK_Commens_To_RegistrationNumbers");
            });

            modelBuilder.Entity<PhotoInfoCard>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.PhotoInfoCards)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhotoInfoCards_To_Comments");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoInfoCards)
                    .HasForeignKey(d => d.PhotoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhotoInfoCards_To_Photos");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PhotoData)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('date')");

                entity.Property(e => e.PhotoExtension)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('extension')");
            });

            modelBuilder.Entity<RegistrationNumber>(entity =>
            {
                entity.HasIndex(e => e.Number)
                    .HasName("UQ_RegistrationNumder_Value")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
