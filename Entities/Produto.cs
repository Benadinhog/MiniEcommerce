using System;

namespace MiniEcommerce.Console.Entities
{
    public class Produto
    {
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public int QuantidadeEstoque { get; private set; }

        public Produto(string nome, decimal preco, int quantidadeEstoque)
        {
            if (preco < 0)
                throw new ArgumentException("O preço do produto não pode ser negativo.");

            if (quantidadeEstoque < 0)
                throw new ArgumentException("A quantidade em estoque não pode ser menor que zero.");

            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade > QuantidadeEstoque)
                throw new InvalidOperationException("Estoque insuficiente.");

            QuantidadeEstoque -= quantidade;
        }
    }
}