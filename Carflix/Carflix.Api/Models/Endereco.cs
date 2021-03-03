using System.ComponentModel.DataAnnotations;

namespace Carflix.Api.Models
{
    public class Endereco : ModelBase
    {
        [Key]
        public int EnderecoId { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Complemento { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Localidade { get; set; }
        [Required]
        public string Uf { get; set; }
        [Required]
        public string Ibge { get; set; }
        [Required]
        public string Gia { get; set; }
        [Required]
        public string DDD { get; set; }
        [Required]
        public string Siafi { get; set; }
    }
}
