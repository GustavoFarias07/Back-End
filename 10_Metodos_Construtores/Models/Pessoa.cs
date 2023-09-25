namespace Models
{
    public class Pessoa
    {
        //Atributos da nossa classe Pessoa
       private string nome { get; set; }
       private int idade { get; set; }
       private string email { get; set; }
       private int anoNascimento { get; set; }

       public Pessoa (string nomePessoa, int idadePessoa , string emailPessoa)
       {
        this.nome = nomePessoa;
        this.idade = idadePessoa;
        this.email = emailPessoa;
        this.anoNascimento = DateTime.Now.Year - idade;
       }

        //Método da classe Pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Informacoes()
        {
            Console.WriteLine($"{nome} de {idade} anos está cantando, email: {email}, Ano de nascimento {anoNascimento}");
        }

    }
}