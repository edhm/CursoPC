using System;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class CursoOnlineContext : DbContext
    {
        public CursoOnlineContext(DbContextOptions options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.InstructorId,ci.CursoId}) ;
        }
    }
}
