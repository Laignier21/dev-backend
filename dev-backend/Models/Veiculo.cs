using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dev_backend.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a placa!")]
        public int Placa { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o Ano de Fabricação!")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricação { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o Ano do Modelo!")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}
