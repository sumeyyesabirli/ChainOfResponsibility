﻿using Microsoft.EntityFrameworkCore;

namespace CasgemChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SUM;initial catalog=DesignPattern;integrated security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
