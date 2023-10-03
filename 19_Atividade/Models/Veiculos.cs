using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _19_Atividade.Models
{
    [Table("Veiculo")]
    public class Veiculos
    {   
        [Key]

         public int VeiculoID { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
    }
}