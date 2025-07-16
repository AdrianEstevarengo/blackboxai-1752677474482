using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Anexo
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string NomeArquivo { get; set; } = string.Empty;

        [Required]
        public byte[] ArquivoByte { get; set; }
        public string TipoArquivo { get; set; }

        public Guid AtividadeId { get; set; }

        public DateTime DataUpload { get; set; } = DateTime.Now;

        [ForeignKey(nameof(AtividadeId))]
        public virtual Atividade Atividade { get; set; } = null!;
    }
}
