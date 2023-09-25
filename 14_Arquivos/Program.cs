using System.IO;

public class Program
{

    public static string CaminhoArquivo = "Arquivo/arquivo2.txt";
    public static void Main()
    {
        GravarArquivo();
        LerArquivo();
    }

    public static void LerArquivo()
    {
        try
        {

            if (File.Exists(CaminhoArquivo) == false)
            {
                File.Create(CaminhoArquivo);
            }

            using (StreamReader arquivo = new StreamReader(CaminhoArquivo))
            {
                string linha;

                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
        }
    }

    public static void GravarArquivo()
    {
        try
        {
            using (StreamWriter arquivo = new StreamWriter(CaminhoArquivo, true))
            {
                Console.WriteLine("Digite a informação para gravar no arquivo:");
                arquivo.WriteLine(Console.ReadLine());
                Console.WriteLine("A informação digitada foi:");
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}