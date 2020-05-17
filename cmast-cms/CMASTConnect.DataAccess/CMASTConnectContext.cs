using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CMASTConnect.DTO.Models;

namespace CMASTConnect.DataAccess
{
    class CMASTConnectContext : DbContext
    {
        private readonly ILoggerFactory _logger;

        public CMASTConnectContext(DbContextOptions<CMASTConnectContext> options) :
            base(options) { }

        protected CMASTConnectContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLoggerFactory(_logger);
                optionsBuilder.UseMySQL("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("CMAST_CONNECT");
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Post>();
        }
    }
}
