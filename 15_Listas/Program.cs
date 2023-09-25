using System.Collections.Generic;
using Sesi.Models;
public class Program
{

    public static void Main()
    {
        //Criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos a lista
        listaNumeros.Add(10);  // posição [0]
        listaNumeros.Add(20);  // posição [1]
        listaNumeros.Add(45);  // posição [2]

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[2]);

        //Contagem do elementos
        Console.WriteLine($" Neste momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55);  // posição [3]
        Console.WriteLine($" Neste momento temos {listaNumeros.Count} elementos");
         Console.WriteLine("##############################");

        List<string> listaNomes = new List<string>();

        //Adicionando elementos a lista
        listaNomes.Add("Gustavo");  // posição [0]
        listaNomes.Add("Maria Fernanda");  // posição [1]
        listaNomes.Add("Patricia");  // posição [2]

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNomes[0]);
        Console.WriteLine(listaNomes[1]);
        Console.WriteLine(listaNomes[2]);

        //Contagem do elementos
        Console.WriteLine($" Neste momento temos {listaNomes.Count} elementos");
        Console.WriteLine("##############################");


        List<int> numeros = new List<int> { 1, 2, 5, 6, 8, 9 };
        Console.WriteLine($"Quantidade de elementos na lista números: {numeros.Count}");
        numeros.Remove(2);  //Remover o elemento 2
        numeros.RemoveAt(1); //Remover o elemento  no indice 1
        numeros.RemoveRange(2,2); //Remover 2 elementos a partir do indice 2  

        //Substituindo informação do item da lista
        numeros[0] = 100;

        //Iterando sobre todos os items da lista
        foreach(int item in numeros)
        {
            Console.WriteLine(item);
        }    

        foreach(string item in listaNomes)
        {
            Console.WriteLine(item);
        }    

        //Criando uma lista com objetos de Classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno novoAluno = new Aluno("Maria Fernanda", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 40));
        listaAlunos.Add(new Aluno("Maria Eduarda", 16));

        Console.WriteLine("Lista Alunos:");
        foreach(Aluno item in listaAlunos)
        {
            Console.WriteLine(item.nome);
            Console.WriteLine(item.idade);
        }   

        //Criando uma nova lista, oredenando por nomes
        //LINQ utilizando Sintaxe de consulta
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 16
                        orderby aluno.nome
                        select  aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }

        var consulta = listaAlunos
                            .Where(aluno => aluno.idade == 16)
                            .OrderBy(aluno => aluno.nome);

        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }


    }
}