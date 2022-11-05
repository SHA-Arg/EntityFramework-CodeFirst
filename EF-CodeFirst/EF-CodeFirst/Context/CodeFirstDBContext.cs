using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Modelo.Context
{
    public class CodeFirstDBContext : DbContext 
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Coneccion con nuestra base SQL Server usando string de conexion
            optionsBuilder.UseSqlServer("Server=SHA-DEV;Initial Catalog=EFCodeFirst;Integrated Security=true");
            
            base.OnConfiguring(optionsBuilder);
        }
        // FluentAPI para ver como se mapea el modelo de clase y las propiedades. 
    }
}
