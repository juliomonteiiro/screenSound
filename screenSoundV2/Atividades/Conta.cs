using System;

//class Conta
//{
//    public int id;
//    public string titular;
//    public int saldo;
//    public string senha;

//    public void ExibeInformacoesDaConta()
//    {
//        Console.WriteLine("INFORMAÇÕES DA CONTA:");
//        Console.WriteLine($"Número da conta: {id}");
//        Console.WriteLine($"Titular da conta: {titular}");
//        Console.WriteLine($"Saldo da conta: {saldo}");
//        Console.WriteLine($"Senha da conta: {senha}");
//        Console.ReadKey();
//    }
//}

//class Conta
//{
//    public int Id { get; set; }
//    public string Titular { get; set; }
//    public int Saldo { get; set; }
//    public string Senha { get; set; }

//    public void ExibeInformacoesDaConta()
//    {
//        Console.WriteLine("INFORMAÇÕES DA CONTA:\n");
//        Console.WriteLine($"Número da conta: {Id}");
//        Console.WriteLine($"Titular da conta: {Titular}");
//        Console.WriteLine($"Saldo da conta: {Saldo}");
//        Console.WriteLine($"Senha da conta: {Senha}\n");
//        Console.ReadKey();
//    }
//}


class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {NumeroDaConta}, Agência {Agencia}, Titular: {Titular.Nome} - Saldo: {Saldo}";
}


