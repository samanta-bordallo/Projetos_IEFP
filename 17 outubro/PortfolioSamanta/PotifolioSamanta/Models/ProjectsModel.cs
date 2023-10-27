using System.ComponentModel.DataAnnotations;

namespace PotifolioSamanta.Models
{
    public class ProjectsModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the project name!")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Is the project finished?!")]
        public string? Finished { get; set; }
        [Required(ErrorMessage = "What is the topic of the project?")]
        public string? Topic { get; set; }
        [Required(ErrorMessage = "Fill in the link!What language is used?")]
        public string? Language { get; set; }
        [Required(ErrorMessage = "Fill in the link!")]
        public string? Link { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
