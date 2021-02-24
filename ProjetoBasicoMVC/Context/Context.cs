using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoBasicoMVC.Models;
using CursoApi.Mapper;

namespace ProjetoBasicoMVC.Models
{
    public class Context: DbContext
    {
        //protected override void OnConfiguring (DbContextOptionsBuilder builder)
        //{
        //    builder.UseSqlServer(@"Server = DESKTOP-NC75SIE\SQLEXPRESS;Database = Cursomvc;Trusted_Connection=True");
        //}
        public Context(DbContextOptions<Context> options): base(options)
        {

        }

        public Context()
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produto { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoriaMap(modelBuilder);
            new ProdutoMap(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
