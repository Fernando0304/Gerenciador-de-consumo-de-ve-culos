using Gerenciador_de_consumo_de_veiculos.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mf_projeto_teste.Models
{
    [Table("Veiculos")]

    public class Veiculo
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informa o nome")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Obrigatório informa a placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informa o Ano de Fabricação")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricação { get; set; }

        [Required(ErrorMessage = "Obrigatório informa o Ano do Modelo")]
        [Display(Name = "Ano de Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
