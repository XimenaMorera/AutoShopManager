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
		public AutoShopManagerContext(DbContextOptions options) : base(options)
        {

        }

		public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Partes> Partess { get; set; }
        public DbSet<Reparacion> Reparaciones { get; set; }
        public DbSet<Cita> Citas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
           
            "Server=(localdb)\\mssqllocaldb;Database=AutoShopManagerDB;Trusted_Connection=True;");

        }

    }
}
