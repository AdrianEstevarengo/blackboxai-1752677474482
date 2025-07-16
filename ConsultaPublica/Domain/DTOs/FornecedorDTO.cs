namespace Domain.DTOs
{
    public class FornecedorDTO
    {
        public string niFornecedor { get; set; } = string.Empty;
        public string nomeRazaoSocialFornecedor { get; set; } = string.Empty;
        public string? porteFornecedorId { get; set; } //bool
        public string? porteFornecedorNome { get; set; } //bool

        public bool IsMEPorteFornecedorNomeBool
        {
            get { return porteFornecedorNome == "ME"; }
        }
        public bool IsMEPortePorteFornecedorIdBool
        {
            get { return porteFornecedorId == "1"; }
        }
    }
}