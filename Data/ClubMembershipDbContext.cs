using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Azure;
using ClassMembershipApplication.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassMembershipApplication.Data
{
    public class ClubMembershipDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"server=HAGEN;database=ClubMembershipDb;Integrated Security=SSPI;TrustServerCertificate=Yes;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}

