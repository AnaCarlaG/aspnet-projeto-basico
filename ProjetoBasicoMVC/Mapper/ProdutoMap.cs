using Microsoft.EntityFrameworkCore;
using ProjetoBasicoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoApi.Mapper
{
    public class ProdutoMap
    {
        public ProdutoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().Property(c => c.Id).IsRequired();

            modelBuilder.Entity<Produto>().HasKey(c => c.Id);

            modelBuilder.Entity<Produto>().Property(c => c.Quantidade).IsRequired();
            modelBuilder.Entity<Produto>().Property(c => c.Descricao).IsRequired();

            modelBuilder.Entity<Produto>().HasOne(p => p.Categoria).WithMany(c => c.Produtos).HasForeignKey(p=>p.CategoriaId);
        }
    }
}
