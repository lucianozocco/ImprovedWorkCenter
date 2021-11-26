using ImprovedWorkCenter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImprovedWorkCenter.Context
{
    public class ImprovedWorkCenterContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-9APFC4I1\\SQLEXPRESS;Database=ImprovedWorkCenterDB;Trusted_Connection=True;");
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Actividad> Socios { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Socio> Actividades { get; set; }
        public DbSet<ActividadSocio> ActividadSocios { get; set; }

    }
}
