using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class AppDbContext : DbContext
    {
        public DbSet<Rule> Rules { get; set; }
        public DbSet<RuleDetail> RuleDetails { get; set; }
        public DbSet<RuleMessage> RuleMessages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=MapPo;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<RuleDetail>()
                .HasOne(rd => rd.Rule)
                .WithMany(r => r.RuleDetails)
                .HasForeignKey(rd => rd.RuleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Rule>()
                .HasOne(r => r.RuleMessage)
                .WithMany(rm => rm.Rules)
                .HasForeignKey(r => r.Mess_ID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
