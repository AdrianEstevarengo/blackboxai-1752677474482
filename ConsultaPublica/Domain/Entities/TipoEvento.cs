using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class TipoEvento
    {
        [Key]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
    }
}