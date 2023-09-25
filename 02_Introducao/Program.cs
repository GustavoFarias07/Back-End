// Somente declarando uma variavel do tipo inteira sem valor
//int num1;

//Declarando uma variavel so tipo inteiro e atribuindo valor 5
//int num2 = 5;

//Declarando variavel String
//string nomeAluno = "Paulo";

//Variavel do tipo lógico (true ou false)
//bool resultado = true;

//Variavel do tipo double valor com varias casas decimais 
//double coordenada = 1.803645628;

//Variavel do tipo decimal - utilizada pra valores
//decimal valor = 1.80M;

int idade = 16 ;
string meuNome = "Gustavo";  
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos"); 
Console.WriteLine("");
Console.WriteLine("Em qual cidade vc nasceu?");
//Readline serve apenas para que eu receba uma informção do usuario
//e armazenamento em um variavel
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Voce nasceu em {nomeCidade}");