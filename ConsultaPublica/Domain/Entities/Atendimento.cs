using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Atendimento
    {
        [Key]
        public Guid Id { get; set; }
        public string Assunto { get; set; } = string.Empty;
        public string CpfCnpj { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
        public string GrauAtendimento { get; set; } = "Urgente";
        public string Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Organizacao { get; set; } = string.Empty;
        public string Observacoes { get; set; } = string.Empty;
        public string NomeResponsavel { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}