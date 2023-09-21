using System;
using System.Collections.Generic;

namespace CRUD_Produto
{
    class ProdutoManager
    {
        private ProdutoRepository repository;

        public ProdutoManager()
        {
            repository = new ProdutoRepository();
        }

        public void AdicionarProduto(string nome)
        {
            Produto produto = new Produto { Nome = nome };
            repository.AdicionarProduto(produto);
        }

        public void RemoverProduto(int id)
        {
            repository.RemoverProduto(id);
        }

        public void EditarProduto(int id, string novoNome)
        {
            repository.EditarProduto(id, novoNome);
        }

        public void VisualizarProdutos()
        {
            List<Produto> produtos = repository.ObterTodosProdutos();

            Console.WriteLine("\nProdutos cadastrados:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}");
            }
        }
    }
}