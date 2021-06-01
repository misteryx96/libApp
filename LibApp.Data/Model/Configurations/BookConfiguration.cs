using System;
using System.Security.Cryptography;
using LibApp.Data.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibApp.Data.Model.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable(nameof(Book), "lib");

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();

            builder.Property(b => b.Code)
                .HasMaxLength(64)
                .IsRequired();

            builder.Property(b => b.Title)
                .HasMaxLength(128)
                .IsRequired();

            builder.Property(b => b.Publisher)
                .HasMaxLength(128);

            builder.Property(b => b.Category)
                .HasMaxLength(32)
                .HasConversion<string>();

            builder.Property(b => b.Issue)
                .HasMaxLength(64);

            builder.Property(b => b.Edition)
                .HasMaxLength(64);

            builder.Property(b => b.IsAvailable)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(b => b.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);


        }
    }
}
