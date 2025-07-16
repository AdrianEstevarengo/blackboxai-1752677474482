namespace Domain.Entities
{
    public class RelatorioEstatistico
    {
        public RelatorioEstatistico()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid AtividadeId { get; set; }
        public Atividade Atividade { get; set; } = new Atividade();
        public string? Legislacao { get; set; }
        public string? NumeroDoProcesso { get; set; }
        public string? NumeroDoCertame { get; set; }
        public string? Objeto { get; set; }
        public string? IdContratacaoPNCP { get; set; }
        public string? dataPublicacaoPncp { get; set; }
        public string? dataAberturaProposta { get; set; }
        public string? dataEncerramentoProposta { get; set; }
        public DateTime DataCriacaoRelatorio { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;
        public string? Ano { get; set; }
        public string? ValorEstimadoGlobal { get; set; }
        public string? ValorNegociadoGlobal { get; set; }
        public string? Pregoeiro { get; set; }
        public string? ElaboradoPor { get; set; }
        public string? RevisadoPor { get; set; }
        public ICollection<Itemsatacollections> ItemsCollection { get; set; } =
            new List<Itemsatacollections>();
    }

    public class Itemsatacollections
    {
        public Itemsatacollections()
        {
            Id = Guid.NewGuid();
            RecursosCollection = new List<Recurso>();
        }

        public Guid Id { get; set; }
        public Guid? RecursoId { get; set; }
        public Guid RelatorioEstatisticoId { get; set; }
        public int OrdemDoItem { get; set; }

        //public string Descricao { get; set; }         //não será salvo
        //public string DescricaoComplementar { get; set; }   //não será salvo
        public string? Quantidade { get; set; }
        public string? ValorEstimado { get; set; }
        public string? ValorNegociado { get; set; }
        public string? Situacao { get; set; }
        public bool? PossuiCota { get; set; }
        public string? EmpresaVencedora { get; set; } //verificar pois como os dados da api vem junto da proposta, no caso array[], verificar a compatibilidade

        //public string RazaoSocial { get; set; }       não será salvo.
        public bool? MeEpp { get; set; }
        public bool? DesempateRegional { get; set; }
        public bool? ro { get; set; }
        public List<Recurso> RecursosCollection { get; set; }

        //public Propostacollections[] PropostaCollection { get; set; }
    }

    public class Recurso
    {
        public Recurso()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid ItemsatacollectionsId { get; set; }
        public string? NumItemRecurso { get; set; }
        public string? DataRecurso { get; set; }
        public string? DataJulgamentoRecurso { get; set; }
        public string? SituacaoJulgamento { get; set; }
    }

    public class Propostacollections //verificar se será usado
    {
        public Propostacollections()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public bool? DeclaracaoMeEppCoop { get; set; }
        public string? QuantidadeDoItem { get; set; }
        public string? ValorUnitario { get; set; }
        public string? ValorGlobal { get; set; }
        public string? DataAtualizacao { get; set; }
        public string? DataResultado { get; set; }
        public string? DescricaoObjetoOfertado { get; set; }
        public string? Item { get; set; }
        public string? CnpjCpf { get; set; }
    }
}
