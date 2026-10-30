using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniEcommerce.Console.Entities
{
    public class CarrinhoDeCompras
    {
        private readonly List<ItemCarrinho> _itens = new List<ItemCarrinho>();
        public IReadOnlyCollection<ItemCarrinho> Itens => _itens.AsReadOnly();

        public void AdicionarItem(Produto produto, int quantidade)
        {
            if (quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            if (quantidade > produto.QuantidadeEstoque)
                throw new InvalidOperationException($"Estoque insuficiente para o produto {produto.Nome}. Disponível: {produto.QuantidadeEstoque}");

            var itemExistente = _itens.FirstOrDefault(i => i.Produto.Nome == produto.Nome);
            if (itemExistente != null)
            {
                if (itemExistente.Quantidade + quantidade > produto.QuantidadeEstoque)
                    throw new InvalidOperationException("A soma das quantidades ultrapassa o estoque disponível.");
                
                // Substitui ou atualiza a quantidade (recriando o item simplificado)
                _itens.Remove(itemExistente);
                _itens.Add(new ItemCarrinho(produto, itemExistente.Quantidade + quantidade));
            }
            else
            {
                _itens.Add(new ItemCarrinho(produto, quantidade));
            }
        }

        public void RemoverItem(string nomeProduto)
        {
            var item = _itens.FirstOrDefault(i => i.Produto.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));
            if (item != null)
                _itens.Remove(item);
        }

        public decimal CalcularSubtotal()
        {
            return _itens.Sum(item => item.Produto.Preco * item.Quantidade);
        }

        public void Limpar()
        {
            _itens.Clear();
        }
    }
}