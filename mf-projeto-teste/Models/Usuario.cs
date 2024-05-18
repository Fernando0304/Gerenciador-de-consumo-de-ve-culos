using System.ComponentModel.DataAnnotations;

namespace Gerenciador_de_consumo_de_veiculos.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ovrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Ovrigatório informar a senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Ovrigatório informar a senha")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil 
    {
        Admin,
        User
    }
}
