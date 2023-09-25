namespace Pant.Model
{

    public class Pantera
    {
        public decimal tamanho { get; set; }
        public int peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentacao { get; set; }

        public void Correr()
        {
            Console.WriteLine($"A Pantera {especie} de {peso}kg e {tamanho}m está correndo");
        }
        public void Cacar()
        {
            Console.WriteLine($"A Pantera {especie} de {peso}kg e {tamanho}m está caçando {alimentacao}");
        }
        public void Reproduzir()
        {
            Console.WriteLine($"A Pantera {especie} de {peso}kg e {tamanho}m está reproduzindo");
        }
    }
}