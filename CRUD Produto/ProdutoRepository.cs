using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_Produto
{
    class ProdutoRepository
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void RemoverProduto(int id)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produtos.Remove(produto);
            }
        }

        public void EditarProduto(int id, string novoNome)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produto.Nome = novoNome;
            }
        }

        public List<Produto> ObterTodosProdutos()
        {
            return produtos;
        }
    }
}