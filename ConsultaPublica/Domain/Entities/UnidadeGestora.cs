using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class UnidadeGestora
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
    }
}
