using AutoShopManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShopManager.Data
{
    public class AutoShopManagerContext :DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
           
            "Server=(localdb)\\mssqllocaldb;Database=AutoShopManagerDB;Trusted_Connection=True;");

        }

    }
}
