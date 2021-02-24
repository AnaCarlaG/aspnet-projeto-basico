using CursoApi.Controllers;
using Microsoft.EntityFrameworkCore;
using Moq;
using ProjetoBasicoMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjetoMVCTest
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _moqContext;
        private readonly Categoria _categoria;
        public CategoriasControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _moqContext = new Mock<Context>();
            _categoria = new Categoria { Id = 1, Descricao = "alimento" };


            //_moqContext.Setup(m => m.Categorias).Returns(_mockSet.Object);
            //_moqContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria);
        }

        [Fact]
        public async Task Get_Categoria()
        {

            var service = new CategoriasController(_moqContext.Object);
            var teste = await service.GetCategoria(1);


            _mockSet.Verify(m => m.FindAsync(1), Times.Once());
        }
    }
}
