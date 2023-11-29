﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DTD_Mentorship_Project.Models;

public partial class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Area { get; set; }

    public virtual DbSet<Mentee> Mentee { get; set; }

    public virtual DbSet<MentorMentee> MentorMentee { get; set; }

    public virtual DbSet<User> User { get; set; }

    public virtual DbSet<UserArea> UserArea { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Scaffolding:ConnectionString", "Data Source=(local);Initial Catalog=DB;Integrated Security=true");

        modelBuilder.Entity<Area>(entity =>
        {
            entity.Property(e => e.AreaId).ValueGeneratedNever();
            entity.Property(e => e.AreaName).HasMaxLength(200);
        });

        modelBuilder.Entity<Mentee>(entity =>
        {
            entity.Property(e => e.MenteeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MentorMentee>(entity =>
        {
            entity.HasOne(d => d.Mentee).WithMany(p => p.MentorMenteeMentee)
                .HasForeignKey(d => d.MenteeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MentorMentee_Mentee");

            entity.HasOne(d => d.Mentor).WithMany(p => p.MentorMenteeMentor)
                .HasForeignKey(d => d.MentorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MentorMentee_Mentor");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.Password).HasMaxLength(200);
        });

        modelBuilder.Entity<UserArea>(entity =>
        {
            entity.HasOne(d => d.Area).WithMany(p => p.UserArea)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserArea_Area");

            entity.HasOne(d => d.User).WithMany(p => p.UserArea)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserArea_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}