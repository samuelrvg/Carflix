using System;

namespace Carflix.Api.Models
{
    public class ModelBase
    {
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; }
    }
}
