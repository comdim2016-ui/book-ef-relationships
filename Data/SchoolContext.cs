using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ClassesManyToMany.Models;

namespace ClassesManyToMany.Data
{
    internal class SchoolContext:DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Subject> Subjects { get; set; } = null!;
        public DbSet<StudentSubject> StudentSubject {  get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=samples;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(m => m.Subjects)
                .WithMany(m => m.Students)
                .UsingEntity<StudentSubject>(
                    m => m.HasOne<Subject>().WithMany(),
                    m => m.HasOne<Student>().WithMany()
                )
                .Property(m=>m.Enrolled)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Student>()
                 .HasOne(sd => sd.StudentData)
                 .WithOne(s => s.Student)
                 .HasForeignKey<StudentData>(s => s.Id);
        }
    }
}
