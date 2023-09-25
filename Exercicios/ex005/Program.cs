﻿class Ex005
{
    public static void Main()
    {
        ListaDoChurrasco();

        //Chamando outro método

    }

    public static void ListaDoChurrasco()
    {
        //Declarar o vetor com 6 posições tipo string
        string[] Lista = new string[6];
        
        //Receber os produtos que precisam ser comprados
        for (int i = 0; i < 6; i++)
        {
            //Console para informar os produtos a comprar
                Console.WriteLine("Informe o produto que vamos comprar");
            //Declarar uma variavel produto para receber oque eu escrever no ReadLine
                string produto = Console.ReadLine();
            //Atribuir no meu vetor o produto que eu digitei pela posição
            Lista[i] = produto;
            
        }

        //Ordernar meu vetor
        Array.Sort(Lista);
        //Para cada item na lista imprimir o produto
        foreach (string item in Lista){
            Console.WriteLine(item);
        }
    }   

    public static void ListaSonhos()
    {
        string[] sonhos = new string[3];
        decimal[] valores = new decimal[3];
        decimal total = 0;

        for (int i = 0; i < 3; i++){
            Console.WriteLine($"Informe o seu {i} sonho");
            string sonho = Console.ReadLine();
            Console.WriteLine($"informe o valor do {i} sonho");
            decimal valor = decimal.Parse(Console.ReadLine());
            sonhos[i] = sonho;
            valores[i] = valor;
        }

        foreach (decimal val in valores)
        {
            total = total + val;
        }
        Console.WriteLine($"Seus sonhos custarão aproximadamente R${total}");


    }
    
}