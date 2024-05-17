using mf_projeto_teste.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciador_de_consumo_de_veiculos.Models
{
    [Table("Consumos")]

    public class Consumo
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a descrição")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data")]
        public DateTime Data {  get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo {  get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o veículo")]
        public int VeiculoId {  get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veículo { get; set; }
    }

    public enum TipoCombustivel 
    {
        Gasolina,
        Etanol
    }
}
