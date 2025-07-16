namespace Infra.CrossCutting.Helpers
{
    public static class ProgressoCalculoHelper
    {
        public static int ProgressoCalculo(string? nomeEvento)
        {
            if (string.IsNullOrWhiteSpace(nomeEvento))
                return 0;

            nomeEvento = nomeEvento.ToLower();

            var grupos = new Dictionary<int, List<string>>
            {
                [10] = new() { "análise de esclarecimento", "fase preparatória", "ajuste no termo de referência", "manifestação unidade gestora", "análise cap", "designação de equipe", "pedido de prioridade", "informação de prioridade" },
                [20] = new() { "cadastro", "download de documentos", "relatório estatístico parcial", "adequação a 14.133", "instrumento provisório", "análise definitiva", "análise material", "instrumento definitivo","instrumento convocatório definitivo", "análise novo tr", "elaboração de relatório final" },
                [30] = new() { "análise de instrumento convocatório", "publicação", "aviso de adiamento", "aviso de reabertura", "aviso de sorteio", "sorteio presencial", "aviso de licitação", "publicação no comprasnet" },
                [50] = new() { "abertura do certame", "recebimento de propostas", "análise de proposta", "análise qualificação técnica", "análise téc. propostas", "ata rp publicada", "cotação de preços", "cotação", "crp", "ata da sessão", "ata da sessão de chamamento público", "reanálise de propostas", "continuação de sessão" },
                [60] = new() { "recurso interposto", "contrarrazões", "julgamento de recurso", "impugnações", "diligências", "análise de impugnação", "pedido de impugnação", "pedido de esclarecimento", "exame de resposta", "análise/manifestação", "análise de recursos", "decisão superior" },
                [75] = new() { "termo de homologação", "trâmites para adjudicação", "rat", "ar", "aprovação do quadro", "emissão de daf" },
                [85] = new() { "assinatura de contrato", "empenho", "nota de empenho", "ordem de fornecimento", "início de execução" },
                [100] = new() { "termo de encerramento", "recebimento definitivo", "relatórios finais", "arquivamento", "finalização de sessões", "conclusão de licitação" }
            };

            foreach (var grupo in grupos)
            {
                if (grupo.Value.Any(e => nomeEvento.Contains(e)))
                    return grupo.Key;
            }

            return 0;
        }
    }
}