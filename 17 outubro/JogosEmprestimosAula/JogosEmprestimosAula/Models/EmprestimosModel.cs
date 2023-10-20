using System.ComponentModel.DataAnnotations;
using System.Data;

namespace JogosEmprestimosAula.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do recebedor!")] 
        public string Recebedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do fornecedor!")]
        public string Fornecedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do jogo!")]
        public string JogoEmprestado { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;
        

    }
}
