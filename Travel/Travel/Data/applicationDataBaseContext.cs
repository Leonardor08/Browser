using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Data
{
    public class applicationDataBaseContext : DbContext
    {
        public applicationDataBaseContext()
        {

        }

        //Creamos un un constructo el cual tomo como paramero las opciones de conexión y recibe la clase
        public applicationDataBaseContext(DbContextOptions<applicationDataBaseContext> options) : base(options)
        {

        }

        //Creamos una propiesdad del tipo data ser sobre la propiedad a manejar la información
        public virtual DbSet<Detail> Details { get; set; }

        //Este metodo lo utilizamos para definir que la propiedad no maneja una llave al ser del tipo Vista
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detail>(a =>
            {
                a.HasNoKey();
                a.ToView("Details");
            });
        }
    }
}
