using System;

namespace MiniEcommerce.Console.Entities
{
    public class Pedido
    {
        public decimal Checkout(CarrinhoDeCompras carrinho)
        {
            if (carrinho == null || carrinho.Itens.Count == 0)
                throw new InvalidOperationException("Não é possível fechar um pedido com o carrinho vazio.");

            // Validar novamente o estoque antes de consolidar tudo
            foreach (var item in carrinho.Itens)
            {
                if (item.Quantidade > item.Produto.QuantidadeEstoque)
                    throw new InvalidOperationException($"Erro no checkout: O estoque do produto {item.Produto.Nome} mudou e não é mais suficiente.");
            }

            decimal totalPedido = carrinho.CalcularSubtotal();

            // Processar a baixa efetiva do estoque
            foreach (var item in carrinho.Itens)
            {
                item.Produto.DebitarEstoque(item.Quantidade);
            }

            // Limpar o carrinho após a compra finalizada
            carrinho.Limpar();

            return totalPedido;
        }
    }
}