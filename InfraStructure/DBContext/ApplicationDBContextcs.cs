
using Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfraStructure.DBContext
{
    public class ApplicationDBContextcs  : DbContext 
    {
        public ApplicationDBContextcs(DbContextOptions<ApplicationDBContextcs> options) : base(options)
        {



        }
        public DbSet<Class> classes { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<TableSubject> Tables { get; set; }
        public DbSet<Teacher> teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

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
        }
        }
}
