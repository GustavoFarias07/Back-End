namespace Banco
{

    public class ContaCorrente
    {
        private double saldo { get; set; }
        private string titular { get; set; }


        public void Bemvindo()
        {
            Console.WriteLine($"Bem vindo(a) {titular}");
        }

        public ContaCorrente(string titularContaCorrente)
        {
            this.saldo = 0;
            this.titular = titularContaCorrente;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"O saldo da conta é {saldo}");
        }
        public void sacar(double Valor)
        {
            double valorSacado = Valor;
            if (valorSacado == 0 || valorSacado > saldo)
            {
                Console.WriteLine("Valor de saque é 0 ou insuficiente");
            }
            else
            {
                saldo = saldo - valorSacado;
                Console.WriteLine($"O valor sacado foi {valorSacado}");
            }
        }
        public void depositar(double Valor)
        {
            double valorDepositado = Valor;
            if (valorDepositado == 0)
            {
                Console.WriteLine("O valor não pode ser depositado");
            }
            else
            {
                saldo = saldo + valorDepositado;
                Console.WriteLine("Valor depositado com sucesso");
            }
        }

    }
}