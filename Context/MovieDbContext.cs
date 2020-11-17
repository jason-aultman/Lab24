using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Lab24.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Lab24.Context
{
    public partial class MovieDbContext : IdentityDbContext
    {
       

        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<CheckedOutMovies> CheckedOutMovies { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        

            modelBuilder.Entity<CheckedOutMovies>(entity =>
            {
                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(450);

            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Genre).HasMaxLength(20);

                entity.Property(e => e.Runtime).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Title).HasMaxLength(50);
                entity.HasData(
                    new { Id = 1, Title = "Something", Genre = "Action", RunTime = 35m });
            });
            base.OnModelCreating(modelBuilder);
        }

       
    }
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MovieDbContext>
    {
        public MovieDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MovieDbContext>();
            builder.UseSqlServer("Server=localhost;Database=MovieDB;Trusted_Connection=true;MultipleActiveResultSets=true");
            return new MovieDbContext(builder.Options);
        }
    }
}
