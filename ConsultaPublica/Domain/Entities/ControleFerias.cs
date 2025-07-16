namespace Domain.Entities
{
    public class ControleFerias
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string CPF { get; set; } = String.Empty;
        public Guid FuncionarioId { get; set; }
        public Funcionario? Funcionario { get; set; }
        public int Periodo { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public bool Abono { get; set; }
    }
}