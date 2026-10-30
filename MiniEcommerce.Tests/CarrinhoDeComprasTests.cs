using Xunit;
using System;
using MiniEcommerce.Console.Entities;

namespace MiniEcommerce.Tests
{
    public class CarrinhoDeComprasTests
    {
        [Fact]
        public void AdicionarItem_ComEstoqueDisponivel_DeveAdicionarComSucesso()
        {
            // Arrange
            var produto = new MeuConsole.Produto("Mouse", 50.00m, 5);
            var carrinho = new MeuConsole.CarrinhoDeCompras();

            // Act
            carrinho.AdicionarItem(produto, 3);

            // Assert
            Assert.Single(carrinho.Itens);
            Assert.Equal(150.00m, carrinho.CalcularSubtotal());
        }

        [Fact]
        public void AdicionarItem_QuantidadeSuperiorAoEstoque_DeveLanciarExcecao()
        {
            // Arrange
            var produto = new Produto("Mouse", 50.00m, 2);
            var carrinho = new CarrinhoDeCompras();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => carrinho.AdicionarItem(produto, 3));
        }
    }
}