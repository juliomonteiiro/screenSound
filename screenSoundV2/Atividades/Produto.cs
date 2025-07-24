using System;

class Produto
{
    private double preco;
    private int estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
                preco = value;
            else
                preco = 10;
        }
    }
    public int Estoque
    {
        get => estoque;
        set
        {
            if (value > 0)
                estoque = value;
            else
                estoque = 0;

        }
    }
    public string Descricao => $"{Nome} {Marca} - {Preco}  - Quantidade: {Estoque}";

    public void ExibirInformacoesProduto()
    {
        Console.WriteLine("Informações do Produto:\n");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Preço: {Preco}");
        Console.WriteLine($"Estoque: {Estoque}\n");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.ReadKey();
    }
}