public class Program
{  
    public static void Main()
    {
        //Criando uma classe anônima (classe sem definição inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa2 é {pessoa2.nome} e o email: {pessoa2.email}");

        //pessoa1.nome = "Gustavo";

        //Criar 2 objetos de classe anonima de Carro

        var Carro1 = new {
            marca = "Volkswagen",
            modelo = "Gol quadrado 1.40 ",
            ano = 1990
        };

        Console.WriteLine($"O carro é da marca {Carro1.marca} no modelo {Carro1.modelo} do ano {Carro1.ano}");

        var Carro2 = new {
            marca = "Volkswagen",
            modelo = "Gol Bolinha",
            ano = 2002
        };

        Console.WriteLine($"O carro é da marca {Carro2.marca} no modelo {Carro2.modelo} do ano {Carro2.ano}");
    }   
}