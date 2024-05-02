using Castle.Components.DictionaryAdapter;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFamework
{
    public class JobContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=COREJobs;Trusted_Connection=true;");
            }
        }
        
        public  DbSet<Emplyoee> Emplyoees { get; set; }

        public  DbSet<Plant> Plants { get; set; }
        public  DbSet<Job> Jobs { get; set; }
        public  DbSet<Test> Tests { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}
