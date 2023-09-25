Console.WriteLine("Digite o nome:");
string nomeAluno = (Console.ReadLine());

Console.WriteLine("Digite a nota1:");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota2:");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota3:");
int nota3 = int.Parse(Console.ReadLine());


int media = (nota1 + nota2 + nota3 ) / 3;

if (media < 7)
{
    Console.WriteLine($"O aluno {nomeAluno} foi reprovado com média {media}");
}
else{
     Console.WriteLine($"O aluno {nomeAluno} foi aprovado com média {media}");
}
