using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
    public class TransferDbContext : DbContext
    {
        //public TransferDbContext() { }

        public TransferDbContext(DbContextOptions options) : base(options)
        {

        }

        //public TransferDbContext(DbContextOptions<TransferDbContext> options) : base(options)
        //{

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BankingDB;User ID=SA;Password=Mudar@4321;MultipleActiveResultSets=true;");
        //    }
        //}

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
