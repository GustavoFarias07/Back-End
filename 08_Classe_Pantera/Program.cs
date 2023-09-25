using Pant.Model;

class Program
{

    public static void Main()
    {
        var pantera1 = new Pantera();   

        Console.WriteLine("Qual tamanho da sua pantera?");
        pantera1.tamanho = decimal.Parse(Console.ReadLine());
         Console.WriteLine("Qual peso da sua pantera? (apenas números)");
        pantera1.peso = int.Parse(Console.ReadLine());
         Console.WriteLine("Qual a cor da sua pantera?");
        pantera1.cor = Console.ReadLine();
         Console.WriteLine("Qual a espécie da sua pantera?");
        pantera1.especie = Console.ReadLine();
         Console.WriteLine("Qual é a alimentação da sua pantera?");
        pantera1.alimentacao = Console.ReadLine();

        pantera1.Correr();
        pantera1.Cacar();
        pantera1.Reproduzir();
    }
}