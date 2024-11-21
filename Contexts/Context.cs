using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;


namespace Bibliotec.Contexts
{

    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<DbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            // if(!optionsBuilder.IsConfigured){
            //     optionsBuilder.UseSqlServer("Data Sounce=NOTE24-S28\\SQLEXPRESS; Initial Catalog = Bibliotec_MVC; User Id=sa; Password=123; Integrated Security=true; TrustServerCertificate = true");
            // }

        }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Livro> Livro { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<LivroCategoria> LivroCategoria { get; set; }
        public DbSet<LivroReserva> LivroReserva { get; set; }

    }
}

