﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DTD_Mentorship_Project;

namespace DTD_Mentorship_Project.Models
{
public partial class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Identity> Identities { get; set; }

    public virtual DbSet<MentorMentee> MentorMentees { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserArea> UserAreas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Scaffolding:ConnectionString", "Data Source=(local);Initial Catalog=DB;Integrated Security=true");

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("StreetAddress");
            entity.Property(e => e.ZipCode).HasColumnName("ZipCode");

            entity.HasOne(d => d.User).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Address_UserId");
        });

       /* modelBuilder.Entity<Area>(entity =>
        {
            entity.ToTable("Area");

            entity.Property(e => e.AreaId).ValueGeneratedNever();
            entity.Property(e => e.AreaName).HasMaxLength(200);
        }); */

        modelBuilder.Entity<Identity>(entity =>
        {
            entity.ToTable("Identity");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdentityName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IdentityName");
        });

        modelBuilder.Entity<MentorMentee>(entity =>
        {
            entity.ToTable("MentorMentee");

            entity.HasOne(d => d.Mentee).WithMany(p => p.MentorMenteeMentees)
                .HasForeignKey(d => d.MenteeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MentorMentee_Mentee");

            entity.HasOne(d => d.Mentor).WithMany(p => p.MentorMenteeMentors)
                .HasForeignKey(d => d.MentorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MentorMentee_Mentor");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Availability).HasColumnType("datetime");
            entity.Property(e => e.Degree).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.Image).HasMaxLength(200);
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.Password).HasMaxLength(200);

            //Eligibility properties
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.Zip).HasMaxLength(200);
            entity.Property(e => e.Company).HasMaxLength(200);
            entity.Property(e => e.DOB).HasColumnType("datetime");
            entity.Property(e => e.FieldofWork).HasMaxLength(200);
            entity.Property(e => e.SelectedUserTypeId).HasMaxLength(200);


            entity.HasOne(d => d.Identity).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdentityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_IdentityId");
        });

        modelBuilder.Entity<UserArea>(entity =>
        {
            entity.ToTable("UserArea");

            entity.HasOne(d => d.Area).WithMany(p => p.UserAreas)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserArea_Area");

            entity.HasOne(d => d.User).WithMany(p => p.UserAreas)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserArea_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
}