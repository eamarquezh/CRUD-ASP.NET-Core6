using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UNIDEH01.Models;

namespace UNIDEH01.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UNIDEH01.Models.Alumnos> Alumnos { get; set; }
        public DbSet<UNIDEH01.Models.Cursos> Cursos { get; set; }
        public DbSet<UNIDEH01.Models.Notas> Notas { get; set; }
        public DbSet<UNIDEH01.Models.Profesores> Profesores { get; set; }
    }
}