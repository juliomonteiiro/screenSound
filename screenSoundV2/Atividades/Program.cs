//Conta conta1 = new Conta();
//conta1.id = 412421;
//conta1.titular = "Julio";
//conta1.saldo = 200000;
//conta1.senha = "sfnsçdfhjsdoghjçoas";

//Console.WriteLine("INFORMAÇÕES DA CONTA:");
//Console.WriteLine($"Titular da conta: {conta1.titular}");
//Console.WriteLine($"Saldo da conta: {conta1.saldo}");

//conta1.ExibeInformacoesDaConta();


//Carro carro1 = new Carro();
//carro1.marca = "Honda";
//carro1.modelo = "Civic SI";
//carro1.ano = 2010;
//carro1.quantidadePortas = 4;

//carro1.ExibirInformacoes();
//carro1.Acelerar();
//carro1.Frear();
//carro1.Buzinar();



//Conta conta1 = new Conta();
//conta1.Id = 412421;
//conta1.Titular = "Julio";
//conta1.Saldo = 200000;
//conta1.Senha = "sfnsçdfhjsdoghjçoas";

//Console.WriteLine("INFORMAÇÕES DA CONTA:\n");
//Console.WriteLine($"Titular da conta: {conta1.Titular}");
//Console.WriteLine($"Saldo da conta: {conta1.Saldo}\n");

//conta1.ExibeInformacoesDaConta();



//Carro carro1 = new Carro();
//carro1.Marca = "Honda";
//carro1.Modelo = "Civic SI";
//carro1.Ano = 2010;
//carro1.QuantidadePortas = 4;

//carro1.ExibirInformacoes();


//Produto produto1 = new Produto();
//produto1.Nome = "Tenis";
//produto1.Marca = "Nike";
//produto1.Preco = 700;
//produto1.Estoque = 20;

//produto1.ExibirInformacoesProduto();


//Titular titular = new();
//Conta conta = new();

//titular.Nome = "Julio Monteiro";
//titular.Cpf = "999.999.999-99";
//titular.Endereco = "Avenida Francisco Glicério - Campinas";

//conta.Titular = titular;
//conta.Agencia = 10;
//conta.NumeroDaConta = 1310;
//conta.Saldo = 99999999.0;
//conta.Limite = 999990.0;

//Console.WriteLine("Informações do Titular: ");
//Console.WriteLine($"Nome: {conta.Titular.Nome}");
//Console.WriteLine($"CPF: {conta.Titular.Cpf}");
//Console.WriteLine($"Endereco: {conta.Titular.Endereco}");
//Console.ReadKey();


Estoque estoque = new Estoque();
Produto produto1 = new Produto();
produto1.Nome = "Tenis";
produto1.Marca = "Nike";
produto1.Preco = 700;
produto1.Estoque = 20;

estoque.AdicionarProduto(produto1);
estoque.ExibirProdutos();
Console.ReadKey();