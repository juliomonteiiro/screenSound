using System.Collections.Generic;

class Estoque
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque\n");
    }
    public void ExibirProdutos()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }
        else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}