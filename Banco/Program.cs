using Banco;

public class Program
{
    public static void Main()
    {
        

        Console.Clear();
        Console.WriteLine("$ $ $ $ $ $ $ $ $ $");
        Console.WriteLine("Bem-Vindo ao Banco");
        Console.WriteLine("$ $ $ $ $ $ $ $ $ $");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";
        Console.WriteLine("Escreva seu nome:");
        ContaCorrente Conta = new ContaCorrente(Console.ReadLine());
        Conta.Bemvindo();

        do
        {
            Console.WriteLine("######## OPÇÕES #######");
            Console.WriteLine("1 - Consultar Saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "4":
                    Console.WriteLine("Saindo do Sistema. . .");
                    System.Threading.Thread.Sleep(1000); //Espera de 1s
                    break;
                case "1":
                    Conta.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Digite o Valor Que Você Quer Depositar:");
                    double valor = double.Parse(Console.ReadLine());
                    Conta.depositar(valor);
                    break;
                case "3":
                    Console.WriteLine("Qual o valor que vc deseja sacar:");
                    double Valor = double.Parse(Console.ReadLine());
                    Conta.sacar(Valor);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }



        } while (opcao != "4");
    }

}