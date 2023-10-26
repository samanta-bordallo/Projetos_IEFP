using System.ComponentModel.DataAnnotations;

namespace ProjetoCarros.Models
{
    public class CarrosModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome da marca!")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Digite o nome do modelo!")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Digite o nome da cor!")]
        public string Cor { get; set; }
        [Required(ErrorMessage = "Digite o ano do carro!")]
        public string Ano { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
