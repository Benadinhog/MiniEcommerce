using Xunit;
using System;
using MeuConsole = MiniEcommerce.Console.Entities; // <-- Apelido aqui

namespace MiniEcommerce.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void CriarProduto_ComDadosValidos_DeveInstanciarComSucesso()
        {
            // Act
            var produto = new MeuConsole.Produto("Notebook", 2500.00m, 10);

            // Assert
            Assert.Equal("Notebook", produto.Nome);
            Assert.Equal(2500.00m, produto.Preco);
            Assert.Equal(10, produto.QuantidadeEstoque);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        public void CriarProduto_ComPrecoNegativo_DeveLanciarExcecao(decimal precoInvalido)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Produto("Notebook", precoInvalido, 10));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-5)]
        public void CriarProduto_ComEstoqueNegativo_DeveLanciarExcecao(int estoqueInvalido)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Produto("Notebook", 1500.00m, estoqueInvalido));
        }
    }
}