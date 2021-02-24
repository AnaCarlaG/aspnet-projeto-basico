using Microsoft.EntityFrameworkCore;
using ProjetoBasicoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoApi.Mapper
{
    public class CategoriaMap
    {
        public CategoriaMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().Property(c => c.Id).IsRequired();

            modelBuilder.Entity<Categoria>().HasKey(c => c.Id);

            modelBuilder.Entity<Categoria>().Property(c => c.Descricao).IsRequired();

            modelBuilder.Entity<Categoria>().HasMany(p => p.Produtos).WithOne(c => c.Categoria).HasForeignKey(p => p.CategoriaId);


        }
    }
}
