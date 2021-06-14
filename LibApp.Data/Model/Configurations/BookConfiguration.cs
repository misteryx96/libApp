﻿using System;
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

            builder.Property(b => b.Category);

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

            builder.HasOne(b => b.Department)
                .WithMany(d => d.Books)
                .HasForeignKey(b => b.DepartmentId);

            builder.Property(b => b.ReservationId);

            builder.HasOne(b => b.Reservation)
                .WithMany(r => r.Books);

            builder.Property(b => b.ReservationId);

            builder.Property(b => b.CreatedTimeStamp)
                .IsRequired();

            builder.Property(b => b.ModifiedTimestamp);
        }
    }
}
