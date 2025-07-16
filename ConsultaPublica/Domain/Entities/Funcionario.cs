using Domain.Enums;

namespace Domain.Entities
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string CPF { get; set; } = String.Empty;
        public SetorialEnum Setorial { get; set; }
        public FuncionarioCargoEnum Cargo { get; set; }
        public FuncionarioCdsEnum CDS { get; set; }
        public FuncionarioClassificacaoEnum ClassificacaoFuncional { get; set; }
        public string ComissionadoEfetivo { get; set; } = String.Empty;
        public DateTime DataAdmissao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; } = String.Empty;
        public string Telefone { get; set; } = String.Empty;
        public string ContatoEmergencia { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public SituacaoFuncionarioEnum Status { get; set; }
    }
}
