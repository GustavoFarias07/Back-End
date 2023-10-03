using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{
    //DataAnnotations de como será criado o nome da tabela noBD
    [Table("Jogos")]
    public class Jogo
    {
        [Key]     //Falando para o banco de dados(BD) que esse atributo sera uma chave
        public int JogoID { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }

    }   
}










