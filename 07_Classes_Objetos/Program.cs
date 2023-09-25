//Sempre que formos utilizar bibliotecas ou classes ja criadas importamos ela com using
using Sesi.Model;

class Program
{
    public static void Main()
    {
        //Crando uma variavel aluno1 e instaciando da classe aluno
        //Ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Gustavo Farias";
        aluno1.idade = 16;
        aluno1.turma = "2º EM";
        //Chamando o método da classe Aluno
        aluno1.Aprensentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.JustificarFaltas(4);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.JustificarFaltas(2);
        aluno1.ResumirFaltas();

        var aluno2 = new Aluno();
        aluno2.nome = "Maria Fernanda";
        aluno2.idade = 16;
        aluno2.turma = "2º EM";
        aluno2.Aprensentar();
    }
}