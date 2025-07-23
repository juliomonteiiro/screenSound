int notaMedia = 6;

if (notaMedia >= 5)
{
   Console.WriteLine("Aprovado");
}



List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };

Console.WriteLine(linguagens[0]);

Console.Write("Digite a posição desejada: ");
int posicao = int.Parse(Console.ReadLine());

Console.WriteLine(linguagens[posicao]);



Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

do
{
   Console.Write("Digite um número entre 1 e 100: ");
   int chute = int.Parse(Console.ReadLine());

   if (chute == numeroSecreto)
   {
       Console.WriteLine("Parabéns! Você acertou o número.");
       break;
   }
   else if (chute < numeroSecreto)
   {
       Console.WriteLine("O número é maior.");
   }
   else
   {
       Console.WriteLine("O número é menor.");
   }

} while (true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");




void ExibirQuatroOperacoes()
{
   float a = 10;
   float b = 30;

   float adicao = a + b;
   float subtracao = a - b;
   float multiplicacao = a * b;
   float divisao = a / b;

   Console.WriteLine($"a + b = {adicao}");
   Console.WriteLine($"a - b = {subtracao}");
   Console.WriteLine($"a x b = {multiplicacao}");
   Console.WriteLine($"a / b = {divisao}");
}
ExibirQuatroOperacoes();




List<string> listaDeBandas = new List<string>();

listaDeBandas.Add("Red Hot Chili Peppers");
listaDeBandas.Add("Linkin Park");
listaDeBandas.Add("Guns N' Roses");

void ExibirListaDeBandas()
{
   Console.WriteLine("Minhas bandas favoritas:\n");
   foreach (string banda in listaDeBandas)
   {
       Console.WriteLine(banda);
   }
   for (int i = 0; i < listaDeBandas.Count; i++)
   {
       Console.WriteLine(listaDeBandas[i]);
   }
}

ExibirListaDeBandas();




List<int> listaDeNumeros = new List<int> {34, 40, 26};
int soma = 0;
void SomaNumerosDaLista()
{

   foreach (int numero in listaDeNumeros)
   {
       soma +=numero;
   }
   Console.WriteLine(soma);
}

SomaNumerosDaLista();




Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

notasAlunos["Julio"] = new List<double> { 10, 10, 9.9 };

foreach (var aluno in notasAlunos)
{
   double soma = 0;
   for(int i = 0; i < aluno.Value.Count; i++)
   {
       soma += aluno.Value[i];
   }
   double media = soma/aluno.Value.Count;
   Console.WriteLine($"A média do aluno {aluno} é {media}");
}




Dictionary<string, int> estoque = new Dictionary<string, int>
{
   { "camisetas", 30 },
   { "calças", 50 },
   { "blusas", 40 },
};

string produto = "blusas";

if (estoque.ContainsKey(produto))
{
   Console.WriteLine($"Possuímos no estoque {estoque[produto]} unidades, de {produto}");
} else
{
   Console.WriteLine("Produto não encontrado");
}




Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
{
   { "Qual é o nome do protagonista do time do povo?", "Yuri Alberto" },
   { "Qual é o melhor meia jogando no futebol brasileiro?", "Rodrigo Garro" },
   { "Quanto é 24 X 38?", "912" },
   { "Qual é o nome da linguagem de programação que tem como simbolo uma cobra?", "Python" },
   { "PHP é conhecido como uma linguagem:", "Single task" },
   { "Qual é o atributo necessário para evolução de um bom desenvolvedor?", "Aprender cada vez mais" },
   { "É os guri?", "Lógico que é" },
};

int pontuacao = 0;

Console.WriteLine("Seja Bem vindo(a) ao quiz\n");

foreach(var pergunta in perguntasERespostas)
{
   Console.WriteLine(pergunta.Key);
   Console.Write("Sua resposta: ");
   string respostaDoUsuario = Console.ReadLine();

   if (respostaDoUsuario.ToLower() == pergunta.Value.ToLower())
   {
       Console.WriteLine("Certa resposta\n");
       pontuacao++;
   } else
   {
       Console.WriteLine($"Errado. A resposta correta é: {pergunta.Value}\n");
   }
}

if (pontuacao > 5)
{
   Console.WriteLine($"Parábens, sua pontuação foi {pontuacao}");
} else
{
   Console.WriteLine($"Sua pontuação foi {pontuacao}, você pode ser melhor, tente novamente!");
}




Dictionary<string, string> login = new Dictionary<string, string>
{
   { "user1", "senha123" },
   { "user2", "abc456" },
};

string nomeUsuario = "user1";
string senha = "senha123";

if (login.ContainsKey(nomeUsuario) && login[nomeUsuario] == senha)
   Console.WriteLine("Login bem-sucedido!");
else
   Console.WriteLine("Nome de usuário ou senha incorretos.");