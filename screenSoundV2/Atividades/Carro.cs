//class Carro
//{
//    public string marca;
//    public string modelo;
//    public int ano;
//    public int quantidadePortas;
//    public int velocidade = 0;

//    public void ExibirInformacoes()
//    {
//        Console.WriteLine("INFORMAÇOES DO CARRO:\n");
//        Console.WriteLine($"Marca: {marca}");
//        Console.WriteLine($"Modelo: {modelo}");
//        Console.WriteLine($"Ano: {ano}");
//        Console.WriteLine($"Quantidade de portas: {quantidadePortas}");
//    }

//    public void Acelerar()
//    {
//        Console.WriteLine("Acelerando...");
//        if (velocidade < 100)
//        {
//            velocidade = velocidade + 5;
//        }
//    }

//    public void Frear()
//    {
//        Console.WriteLine("Freando...");
//        if (velocidade > 0)
//        {
//            velocidade = velocidade - 5;
//        }
//    }

//    public void Buzinar()
//    {
//        Console.WriteLine("Bi Bi");
//    }
//}

using System;

class Carro
{
    private int ano;
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano
    {
        get => ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                ano = value;
            }
        }
    }
    public int QuantidadePortas { get; set; }
    public string DescricaoDetalhada =>
        $"Carro: {Marca} {Modelo} {Ano}";

    public void ExibirInformacoes()
    {
        Console.WriteLine("INFORMAÇOES DO CARRO:\n");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Quantidade de portas: {QuantidadePortas}");
        Console.WriteLine($"Descrição: {DescricaoDetalhada}");
        Console.ReadKey();
    }
}
