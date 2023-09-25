//Função em JavaScript
//function nomeFuncao (nome) {}

//Função / Método em C#
//public static void nomeFuncao(string nome) {}

class Sesi{

    public static void Main()
    {
        //Chamando métodos sem retorno
        MostrarMensagem("Seja bem-vindo");
        MostrarMensagem("Sesi / Senai");
        imprimirDataHora();
        //Chamando o método Potenciação com o parâmetro 4 e recebendo o retorno
        double potencia = Potenciacao(4);
        Console.WriteLine($"Pontenciação {potencia}");

        ContagemRegressiva(10);
        JogoQueNrSouEu();
    }

    //Método com parâmetro e com retorno
    public static double Potenciacao(int num){
        double resultado = Math.Pow(num, 2);
        return resultado;
    }
     public static void imprimirDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }
    public static void MostrarMensagem(string mensagem) 
    {
   Console.WriteLine(mensagem);
    }

    public static void ContagemRegressiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n --;   //n = n - 1
            System.Threading.Thread.Sleep(500); //500 milissegundos (ms)
        }
        Console.WriteLine("BOOOOOOM");
    }

    public static void JogoQueNrSouEu()
    {
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("         Bem vindo ao jogo                 ");
        Console.WriteLine("Sorteei um nº de 1 a 20, tente adivinha-lo ");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("");  //Linha em branco

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = 1;

        do {
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
               Console.WriteLine("O número digitando é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
               Console.WriteLine("O número digitando é MENOR que o sorteado");
        } while (nrDigitado != nrSorteado);

        Console.WriteLine("Parabéns você acertou");
    }
}
