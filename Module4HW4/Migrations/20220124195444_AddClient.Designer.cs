﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module4HW4;

namespace Module4HW4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220124195444_AddClient")]
    partial class AddClient
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Module4HW4.Entity.ClientEntity", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Birthday = new DateTime(2001, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Vadim",
                            Language = "UA",
                            SecondName = "Bilyi"
                        },
                        new
                        {
                            ClientId = 2,
                            Birthday = new DateTime(2001, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Dima",
                            Language = "UA",
                            SecondName = "Yampolskiy"
                        },
                        new
                        {
                            ClientId = 3,
                            Birthday = new DateTime(2000, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Dima",
                            Language = "UA",
                            SecondName = "Menshakov"
                        },
                        new
                        {
                            ClientId = 4,
                            Birthday = new DateTime(2001, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Roma",
                            Language = "RU",
                            SecondName = "Momot"
                        },
                        new
                        {
                            ClientId = 5,
                            Birthday = new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Sergay",
                            Language = "UA",
                            SecondName = "Naimutenko"
                        });
                });

            modelBuilder.Entity("Module4HW4.Entity.EmployeeEntity", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HiredDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Module4HW4.Entity.EmployeeProjectEntity", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("money");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProject");
                });

            modelBuilder.Entity("Module4HW4.Entity.OfficeEntity", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OfficeId");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("Module4HW4.Entity.ProjectEntity", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Budget = 100000m,
                            ClientId = 1,
                            Name = "Pockemon GO",
                            StartedDate = new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 2,
                            Budget = 100000m,
                            ClientId = 2,
                            Name = "Project F",
                            StartedDate = new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 3,
                            Budget = 1000m,
                            ClientId = 4,
                            Name = "Diya",
                            StartedDate = new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 4,
                            Budget = 1000000m,
                            ClientId = 5,
                            Name = "Pockemon Unite",
                            StartedDate = new DateTime(2017, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 5,
                            Budget = 20m,
                            ClientId = 3,
                            Name = "Medical Mathematic Project",
                            StartedDate = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Module4HW4.Entity.TitleEntity", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TitleId");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("Module4HW4.Entity.EmployeeEntity", b =>
                {
                    b.HasOne("Module4HW4.Entity.OfficeEntity", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4HW4.Entity.TitleEntity", "Title")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Module4HW4.Entity.EmployeeProjectEntity", b =>
                {
                    b.HasOne("Module4HW4.Entity.EmployeeEntity", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4HW4.Entity.ProjectEntity", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Module4HW4.Entity.ProjectEntity", b =>
                {
                    b.HasOne("Module4HW4.Entity.ClientEntity", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Module4HW4.Entity.ClientEntity", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Module4HW4.Entity.EmployeeEntity", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Module4HW4.Entity.OfficeEntity", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Module4HW4.Entity.ProjectEntity", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Module4HW4.Entity.TitleEntity", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}