using System;

namespace CRUD_Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoManager produtoManager = new ProdutoManager();
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Remover Produto pelo ID");
                Console.WriteLine("3. Editar Produto pelo ID");
                Console.WriteLine("4. Visualizar todos os Produtos");
                Console.WriteLine("5. Sair\n");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nDigite o nome do produto:");
                        string nome = Console.ReadLine();
                        produtoManager.AdicionarProduto(nome);
                        Console.WriteLine("Produto adicionado com sucesso!");
                        break;
                    case 2:
                        Console.WriteLine("\nDigite o ID do produto a ser removido:");
                        int idRemover = Convert.ToInt32(Console.ReadLine());
                        produtoManager.RemoverProduto(idRemover);
                        Console.WriteLine("Produto removido com sucesso!");
                        break;
                    case 3:
                        Console.WriteLine("\nDigite o ID do produto a ser editado:");
                        int idEditar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o novo nome do produto:");
                        string novoNome = Console.ReadLine();
                        produtoManager.EditarProduto(idEditar, novoNome);
                        Console.WriteLine("Produto editado com sucesso!");
                        break;
                    case 4:
                        produtoManager.VisualizarProdutos();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}