using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.MyContext
{
    public class MyDBContext: DbContext , IContex
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Hmo> Hmos { get; set; }
        public DbSet<Child> Childs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Child>()
                .HasOne(c => c.User)
                .WithMany(u => u.Children)
                .HasForeignKey(c => c.UserId);

                   }


        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyDBName;Trusted_Connection=True");
        }


    }
}
