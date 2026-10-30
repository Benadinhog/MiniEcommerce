using Xunit;
using System;
using MiniEcommerce.Console.Entities;

namespace MiniEcommerce.Tests
{
    public class PedidoTests
    {
        [Fact]
        public void FinalizarPedido_DeveDiminuirEstoqueECalcularTotalCorretamente()
        {
            // Arrange
            var produto = new MeuConsole.Produto("Teclado", 100.00m, 10);
            var carrinho = new MeuConsole.CarrinhoDeCompras();
            carrinho.AdicionarItem(produto, 2);

            var pedidoService = new MeuConsole.Pedido();

            // Act
            var total = pedidoService.Checkout(carrinho);

            // Assert
            Assert.Equal(200.00m, total);
            Assert.Equal(8, produto.QuantidadeEstoque); // Baixou de 10 para 8
            Assert.Empty(carrinho.Itens); // Carrinho deve ser limpo pós-venda
        }
    }
}