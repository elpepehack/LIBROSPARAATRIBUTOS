using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3_PILCO_JOSE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace T3_PILCO_JOSE.Datos

   {
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Registrar la entidad Libro
        public DbSet<Libro> Libros { get; set; }
    }
}