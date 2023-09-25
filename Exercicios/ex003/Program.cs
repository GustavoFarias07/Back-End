Console.WriteLine("Digite o mês em número:");
int diaMes = int.Parse(Console.ReadLine());

switch (diaMes)
{
    case 1:
         Console.WriteLine("Estamos no mês de Janeiro, 31 dias");
         break;
    case 2:
         Console.WriteLine("Estamos no mês de Feverreiro, 28 dias");
         break;
    case 3:
         Console.WriteLine("Estamos no mês de Março, 31 dias");
         break;
    case 4:
         Console.WriteLine("Estamos no mês de Abril, 30 dias");
         break;
    case 5:
         Console.WriteLine("Estamos no mês de Maio, 31 dias");
         break;
    case 6:
         Console.WriteLine("Estamos no mês de Junho, 30 dias");
         break;
    case 7:
         Console.WriteLine("Estamos no mês de Julho, 31 dias");
         break;
    case 8:
         Console.WriteLine("Estamos no mês de Agosto, 31 dias");
         break;
    case 9:
         Console.WriteLine("Estamos no mês de Setembro, 30 dias");
         break;
    case 10:
         Console.WriteLine("Estamos no mês de Outubro, 31 dias");
         break;
    case 11:
         Console.WriteLine("Estamos no mês de Novembro, 30 dias");
         break;
    case 12:
         Console.WriteLine("Estamos no mês de Dezembro, 31 dias");
         break;
     default:
         Console.WriteLine("mês inválido");
         break;
}