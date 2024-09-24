﻿// <auto-generated />
using System;
using InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfraStructure.Migrations
{
    [DbContext(typeof(ApplicationDBContextcs))]
    [Migration("20240920200936_school")]
    partial class school
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.Property<int>("TeachersId")
                        .HasColumnType("int");

                    b.Property<int>("classesId")
                        .HasColumnType("int");

                    b.HasKey("TeachersId", "classesId");

                    b.HasIndex("classesId");

                    b.ToTable("ClassTeacher");
                });

            modelBuilder.Entity("Domains.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberofStudents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberofSubjects")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("enddate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("startdate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("classes");
                });

            modelBuilder.Entity("Domains.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("average")
                        .HasColumnType("float");

                    b.Property<DateOnly>("birthday")
                        .HasColumnType("date");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("Domains.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("Domains.Models.TableSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("className")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("Domains.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("birthday")
                        .HasColumnType("date");

                    b.Property<string>("imgurl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.Property<int>("studentsId")
                        .HasColumnType("int");

                    b.Property<int>("teachersId")
                        .HasColumnType("int");

                    b.HasKey("studentsId", "teachersId");

                    b.HasIndex("teachersId");

                    b.ToTable("StudentTeacher");
                });

            modelBuilder.Entity("ClassTeacher", b =>
                {
                    b.HasOne("Domains.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("classesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domains.Models.Student", b =>
                {
                    b.HasOne("Domains.Models.Class", "classes")
                        .WithMany("Students")
                        .HasForeignKey("ClassId");

                    b.Navigation("classes");
                });

            modelBuilder.Entity("Domains.Models.Subject", b =>
                {
                    b.HasOne("Domains.Models.Class", "classes")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Domains.Models.Student", "studentes")
                        .WithMany("subjects")
                        .HasForeignKey("StudentId");

                    b.HasOne("Domains.Models.Teacher", "Teacheres")
                        .WithMany("subjects")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Teacheres");

                    b.Navigation("classes");

                    b.Navigation("studentes");
                });

            modelBuilder.Entity("Domains.Models.TableSubject", b =>
                {
                    b.HasOne("Domains.Models.Class", "classes")
                        .WithMany("Tables")
                        .HasForeignKey("ClassId");

                    b.HasOne("Domains.Models.Subject", "Subjectes")
                        .WithMany("Tables")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subjectes");

                    b.Navigation("classes");
                });

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.HasOne("Domains.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("studentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("teachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domains.Models.Class", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("Domains.Models.Student", b =>
                {
                    b.Navigation("subjects");
                });

            modelBuilder.Entity("Domains.Models.Subject", b =>
                {
                    b.Navigation("Tables");
                });

            modelBuilder.Entity("Domains.Models.Teacher", b =>
                {
                    b.Navigation("subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
