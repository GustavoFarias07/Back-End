class Sesi{
    public static void Main()
    {
         double valorDobro = Dobro(12);

         Console.WriteLine($"O dobro é {valorDobro}");

         double valorMetade = Metade(6);
         Console.WriteLine($"A metade é {valorMetade}");

         Console.WriteLine($"Digite um número");
         int n = int.Parse(Console.ReadLine());
         ContagemTabuada(n);   

         ResumoSalarios();
    }

    public static double Dobro( int Valor)
    {
        double resultado = Valor * 2;

        return resultado;
    }

      public static double Metade( int ValorM)
    {
        double resultadoM = ValorM / 2;

        return resultadoM;
    }

     public static void ContagemTabuada(int valor)
    {
        int n = 0;

        while (n <= 9)
        {
            n++;
             Console.WriteLine($"{n} X {valor} = {n * valor}");
        }

    }


    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;

        do {
            Console.WriteLine("Digite o salário do empregado");
            salarioEmpregado = int.Parse(Console.ReadLine());
            
            if (salarioEmpregado > 0)
            somaSalarios = somaSalarios + salarioEmpregado;
            //somaSalários += salárioEmpregado
            if (salarioEmpregado > maiorSalario){
                maiorSalario = salarioEmpregado;
            }
            if  (salarioEmpregado < menorSalario  && salarioEmpregado > 0){
                  menorSalario = salarioEmpregado;     
            }
        } while (salarioEmpregado > 0);

        Console.WriteLine($"A soma dos salários é {somaSalarios}, e o maior salário é {maiorSalario} e o menor salário é {menorSalario}");
    }
    

}
