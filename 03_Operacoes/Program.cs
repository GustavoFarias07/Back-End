Console.WriteLine("Digite o valor de x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

// Exemplos de operadores aritméticos
int soma = x + y;
int subtrcao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;
int restoYDiv3 = y % 2;

//Console para exibir na tela as variaveis em cada linha
//Soma: 15 

Console.WriteLine($"A soma é {soma}");
Console.WriteLine($"A subtrção é {subtrcao }");
Console.WriteLine($"A multiplicacao é {multiplicacao}");
Console.WriteLine($"A divisao é {divisao}");
Console.WriteLine($"O resto é {resto}");

if (restoDiv2 == 0)
{
    Console.WriteLine($"O numero {x} é par");
}
else
{
    Console.WriteLine($"O numero {x} é impar");
}


if (restoYDiv3 == 0)
{
    Console.WriteLine($"O numero {y} é par");
}
else
{
     Console.WriteLine($"O numero {y} é impar");
}

string resultado = (restoYDiv2 == 0) ? $"O número {y} é par" : $"O número {y} é impar";
Console.WriteLine(resultado);

int diaSemana = 3;
//Aprendendo o Switch Case
switch (diaSemana)
{
    case 1:
         Console.WriteLine("Hoje é domingo!");
         break;
    case 2:
         Console.WriteLine("Hoje é segunda!");
         break;
    case 3:
         Console.WriteLine("Hoje é terça!");
         break;
    case 4:
         Console.WriteLine("Hoje é quarta!");
         break;
    case 5:
         Console.WriteLine("Hoje é quinta!");
         break;
    case 5:
         Console.WriteLine("Hoje é sexta!");
         break;
    case 7:
         Console.WriteLine("Hoje é sabado!");
         break;
     default:
         Console.WriteLine("Dia inválido")
         break;
}