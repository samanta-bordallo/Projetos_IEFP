namespace ProjetoCarros.Models
{
    public class CarrosModel
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Ano { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
