Console.WriteLine("Digite sua placa:");
string Carroplaca = (Console.ReadLine());

string ultimo = Carroplaca.Substring(Carroplaca.Length - 1, 1);

Console.WriteLine($"O seu final é {ultimo}");

if (ultimo == "1" || ultimo == "2")
{
    Console.WriteLine("Voce nao pode andar na segunda-feira");
}
else if (ultimo == "3" || ultimo == "4")
{
    Console.WriteLine("Voce nao pode andar na terça-feira");
}
else if (ultimo == "5" || ultimo == "6")
{
    Console.WriteLine("Voce nao pode andar na quarta-feira");
}
else if (ultimo == "7" || ultimo == "8")
{
    Console.WriteLine("Voce nao pode andar na quinta-feira");
}
else if (ultimo == "9" || ultimo == "0")
{
    Console.WriteLine("Voce nao pode andar na sexta-feira");
}