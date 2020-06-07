using Livraria.v1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasKey(t => t.Id);
            modelBuilder.Entity<Livro>().HasKey(t => t.Id);
            modelBuilder.Entity<InstituicaoEnsino>().HasKey(t => t.Id);
            modelBuilder.Entity<Emprestimo>().HasKey(e => e.Id);
        }
    }
}
