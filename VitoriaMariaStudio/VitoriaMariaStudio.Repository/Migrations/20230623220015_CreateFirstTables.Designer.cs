﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VitoriaMariaStudio.Repository.Context;

#nullable disable

namespace VitoriaMariaStudio.Repository.Migrations
{
    [DbContext(typeof(StudioDbContext))]
    [Migration("20230623220015_CreateFirstTables")]
    partial class CreateFirstTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JobScheduling", b =>
                {
                    b.Property<long>("JobsId")
                        .HasColumnType("bigint");

                    b.Property<long>("SchedulingsId")
                        .HasColumnType("bigint");

                    b.HasKey("JobsId", "SchedulingsId");

                    b.HasIndex("SchedulingsId");

                    b.ToTable("SchedulingJob", (string)null);
                });

            modelBuilder.Entity("VitoriaMariaStudio.Domain.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("VitoriaMariaStudio.Domain.Entities.Job", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(125)
                        .IsUnicode(false)
                        .HasColumnType("varchar(125)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("VitoriaMariaStudio.Domain.Entities.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(125)
                        .IsUnicode(false)
                        .HasColumnType("varchar(125)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(125)
                        .IsUnicode(false)
                        .HasColumnType("varchar(125)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(125)
                        .IsUnicode(false)
                        .HasColumnType("varchar(125)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("VitoriaMariaStudio.Domain.Entities.Professional", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(125)
                        .IsUnicode(false)
                        .HasColumnType("varchar(125)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(125)
                        .IsUnicode(false)
                        .HasColumnType("varchar(125)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(125)
                        .IsUnicode(false)
                        .HasColumnType("varchar(125)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Professionals");
                });

            modelBuilder.Entity("VitoriaMariaStudio.Domain.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("VitoriaMariaStudio.Domain.Entities.Scheduling", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<long>("ProfessionalId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProfessionalId");

                    b.ToTable("Schedulings");
                });

            modelBuilder.Entity("JobScheduling", b =>
                {
                    b.HasOne("VitoriaMariaStudio.Domain.Entities.Job", null)
                        .WithMany()
                        .HasForeignKey("JobsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VitoriaMariaStudio.Domain.Entities.Scheduling", null)
                        .WithMany()
                        .HasForeignKey("SchedulingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VitoriaMariaStudio.Domain.Entities.Job", b =>
                {
                    b.HasOne("VitoriaMariaStudio.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("VitoriaMariaStudio.Domain.Entities.Professional", b =>
                {
                    b.HasOne("VitoriaMariaStudio.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("VitoriaMariaStudio.Domain.Entities.Scheduling", b =>
                {
                    b.HasOne("VitoriaMariaStudio.Domain.Entities.Person", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VitoriaMariaStudio.Domain.Entities.Professional", "Professional")
                        .WithMany()
                        .HasForeignKey("ProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Professional");
                });
#pragma warning restore 612, 618
        }
    }
}
