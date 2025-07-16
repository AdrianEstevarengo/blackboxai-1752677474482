using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum EOrgao
    {
        [Display(Name = "Outros")]
        OUTROS = 1,

        [Display(Name = "ABAITARÁ - INSTITUTO ESTADUAL DE EDUCAÇÃO RURAL")]
        ABAITARA = 105,

        [Display(Name = "ACRIAR - Associação de Cristãos para Ação nas Ruas")]
        ACRIAR = 51,

        [Display(Name = "ACZ - ARACRUZ - ES")]
        ACZ = 67,

        [Display(Name = "AGEVISA - Agência Estadual de Vigilância Sanitária")]
        AGEVISA = 19,

        [Display(Name = "CAERD - COMPANHIA DE ÁGUAS E ESGOTOS DE RONDÔNIA")]
        CAERD = 98,

        [Display(Name = "CBM - CORPO DE BOMBEIRO MILITAR")]
        CBM = 86,

        [Display(Name = "CBMRO - Corpo de Bombeiros Militar")]
        CBMRO = 71,

        [Display(Name = "CETAS - Centro de Educação Técnico Profissional na Área da Saúde")]
        CETAS = 27,

        [Display(Name = "CGAA - Coordenadoria Geral de Apoio Administrativo")]
        CGAA = 29,

        [Display(Name = "CGAG - Coordenadoria Geral de Apoio a Governadoria")]
        CGAG = 17,

        [Display(Name = "CGE - Controladoria Geral do Estado")]
        CGE = 26,

        [Display(Name = "CGM/PV - CONTROLADORIA GERAL DO MUNICÍPIO DE PORTO VELHO")]
        CGM_PV = 92,

        [Display(Name = "CMCJ - CÂMARA MUN. DE CANDEIAS DO JAMARI")]
        CMCJ = 110,

        [Display(Name = "CMOPO - CÂMARA MUNICIPAL DE OURO PRETO DO OESTE")]
        CMOPO = 62,

        [Display(Name = "CMR - Companhia de Mineração de Rondônia")]
        CMR = 37,

        [Display(Name = "COHAB - COMPANHIA DE HABITAÇÃO DO ESTADO DO PARÁ")]
        COHAB = 104,

        [Display(Name = "COGES-Contabilidade Geral do Estado")]
        COGES = 8563,

        [Display(
            Name = "CONEN - Conselho Estadual de Políticas Públicas Sobre Drogas, Fundo Estadual de Prev.Fisc.Repressão de Entorpecentes"
        )]
        CONEN = 47,

        [Display(Name = "CONSSAUDE - CONSELHO ESTADUAL DE SAÚDE")]
        CONS_SAUDE = 66,

        [Display(Name = "CPOAD - Coordenadoria de Estado de Políticas sobre Drogas")]
        CPOAD = 114,

        [Display(
            Name = "DEMAC - SECRETARIA MUNICIPAL DE SAÚDE DEPARTAMENTO DE MEDIA E ALTA COMPLEXIDADE"
        )]
        DEMAC = 107,

        [Display(Name = "DEOSP - Departamento de Obras e Serviços Públicos")]
        DEOSP = 21,

        [Display(Name = "DER - Departamento de Estradas de Rodagem e Transportes")]
        DER = 18,

        [Display(Name = "DETRAN - Departamento Estadual de Trânsito")]
        DETRAN = 31,

        [Display(Name = "DPE - Defensoria Pública do Estado de Rondônia")]
        DPE = 38,

        [Display(
            Name = "EMATER - ASSOCIAÇÃO DE ASSISTÊNCIA TÉCNICA E EXTENSÃO RURAL DO ESTADO DE RONDÔNIA"
        )]
        EMATER = 106,

        [Display(Name = "EPR - Estado para Resultados")]
        EPR = 49,

        [Display(
            Name = "FAPERO - FUNDAÇÃO RONDÔNIA DE AMPARO AO DESENVOLVIMENTO DAS AÇÕES CIENTÍFICAS E TECNOLÓGICAS E A PESQUISA DO ESTADO DE RONDÔNIA "
        )]
        FAPERO = 88,

        [Display(
            Name = "FAPERO/2 - Fundação Rondônia de Amparo ao Desenvolvimento das Ações Científicas e Tecnologicas e à Pesquisa do Estado de Rondônia"
        )]
        FAPERO_2 = 78,

        [Display(Name = "FEAS - Fundo Estadual de Assistência Social")]
        FEAS = 40,

        [Display(Name = "FEASE - Fundação Estadual de Atendimento Socioeducativo")]
        FEASE = 113,

        [Display(Name = "FEPRAM - Fundo Especial de Proteção Ambiental")]
        FEPRAM = 36,

        [Display(Name = "FESA -  Fundo Estadual de Sanidade Animal")]
        FESA = 1123,

        [Display(
            Name = "FESPREN - Fundo Estadual de Prevenção Fiscalização e Repressão de Entorpecentes"
        )]
        FESPREN = 53,

        [Display(Name = "FHEMERON - Fundação Hemeron")]
        FHEMERON = 15,

        [Display(
            Name = "FIDER - Fundo de Investimento e de Desenvolvimento Industrial do Estado de Rondônia"
        )]
        FIDER = 48,

        [Display(Name = "FISP - Fundo de Investimento de Segurança Pública - Pará")]
        FISP = 82,

        [Display(Name = "FUNCAFE - Fundo de Apoio à Cafeicultura")]
        FUNCAFE = 23,

        [Display(Name = "FUNCER - Fundação Cultural do Estado de Rondônia")]
        FUNCER = 115,

        [Display(Name = "FUNCULTURAL - FUNDAÇÃO CULTURAL DO MUNICÍPIO DE PORTO VELHO")]
        FUNCULTURAL = 93,

        [Display(
            Name = "FUND.RO - Fundação de Amparo ao Desenvolvimento das Ações Científicas e Tecnológicas e à Pesquisa"
        )]
        FUND_RO = 45,

        [Display(Name = "FUNEDCA - Fundo Estadual dos Direitos da Criança e do Adolescente")]
        FUNEDCA = 41,

        [Display(Name = "FUNESBOM - Fundo Especial do Corpo de Bombeiros")]
        FUNESBOM = 20,

        [Display(Name = "FUNRESPOL - Fundo Especial de Reequipamento Policial")]
        FUNRESPOL = 33,

        [Display(
            Name = "FUNRESPOM - Fundo Especial de Modernização e Reaparelhamento da Polícia Militar"
        )]
        FUNRESPOM = 30,

        [Display(Name = "FUPEN - Fundo Penitenciário")]
        FUPEN = 39,

        [Display(Name = "GFHAJ/AM - FUNDAÇÃO HOSPITAL ADRIANO JORGE")]
        GFHAJ_AM = 101,

        [Display(Name = "HRAS - SECRETARIA DE SAÚDE DO ESPIRITO SANRO")]
        HRAS = 100,

        [Display(Name = "HRSFG - HOSPITAL REGIONAL DE SÃO FRANCISCO DO GUAPORÉ")]
        HRSFG = 109,

        [Display(Name = "I.ABAITARA - INSTITUTO ESTADUAL DE EDUCAÇÃO RURAL ABAITARÁ")]
        I_ABAITARA = 94,

        [Display(Name = "IDARON - Agência de Defesa Sanitária Agrosilvopastoril")]
        IDARON = 12,

        [Display(Name = "IDEP/RO - Instituto Estadual de Desenvolvimento da Educação Profissional")]
        IDEP = 1119,

        [Display(Name = "IPEM - Instituto de Pesos e Medidas do Estado de Rondônia")]
        IPEM = 34,

        [Display(Name = "IPERON - Instituto de Previdência dos Servidores Públicos de Rondônia")]
        IPERON = 35,

        [Display(Name = "JUCER - Junta Comercial do Estado de Rondônia")]
        JUCER = 14,

        [Display(Name = "LACEN - LABORATÓRIO CENTRAL DE SAUDE PUBLICA")]
        LACEN = 123,

        [Display(Name = "MP - MINISTÉRIO PÚBLICO DO ESTADO DE RONDÔNIA")]
        MP = 81,

        [Display(Name = "PC - POLÍCIA CIVIL")]
        PC = 73,

        [Display(Name = "PGE - Procuradoria Geral do Estado")]
        PGE = 13,

        [Display(Name = "PM - POLÍCIA MILITAR")]
        PM = 80,

        [Display(Name = "PMA - PREFEITURA DE ARIQUEMES")]
        PMA = 58,

        [Display(Name = "PM/ACRE - POLÍCIA MILITAR")]
        PM_ACRE = 95,

        [Display(Name = "PMPB - PREFEITURA DO MUNICIPIO DE PIMENTA BUENO")]
        PMPB = 89,

        [Display(Name = "PMPV - Prefeitura do Município de Porto Velho")]
        PMPV = 44,

        [Display(Name = "PMT - PREF.MUNICIPAL DE THEOBROMA")]
        PMT = 91,

        [Display(Name = "POLITEC - Superintenência de Policia Tecnico-Científico de Rondônia")]
        POLITEC = 1121,

        [Display(Name = "PREF.ARIQUEMES - PREFEITURA MUNICIPAL DE ARIQUEMES")]
        PREF_ARIQUEMES = 84,

        [Display(Name = "PREF.ARIQUEMES/2 - PREFEITURA MUNICIPAL DE ARIQUEMES")]
        PREF_ARIQUEMES_2 = 85,

        [Display(Name = "PREF.CACOAL - PREFEITURA MUNICIPAL DE CACOAL")]
        PREF_CACOAL = 63,

        [Display(Name = "PREF.CASTANHEIRAS - PREFEITURA MUNICIPAL DE CASTANHEIRAS")]
        PREF_CASTANHEIRAS = 97,

        [Display(Name = "PREF.CUJUBIM - PREFEITURA DO MUNICÍPIO DE CUJUBIM")]
        PREF_CUJUBIM = 99,

        [Display(Name = "PREF.JARU - PREFEITURA MUNICIPAL DE JARU")]
        PREF_JARU = 83,

        [Display(Name = "PREF.JI PARANA - PREFEITURA MUNICIPAL DE JI - PARANÁ")]
        PREF_JI_PARANA = 102,

        [Display(Name = "PREF.ROLIM - Prefeitura Municipal Rolim de Moura")]
        PREF_ROLIM = 55,

        [Display(Name = "Pref.Santa Luzia - Prefeitura Municipal Santa Luzia D` Oeste")]
        Pref_Santa_Luzia = 90,

        [Display(Name = "PREFEITURA_ALTO_ALEGRE - Prefeitura Municipal de Alto Alegre")]
        PREFEITURA_ALTO_ALEGRE = 108,

        [Display(
            Name = "PROLEITE - Fundo de Investimento e Apoio ao Programa de Desenvolvimento da Pecuária Leiteira"
        )]
        PROLEITE = 24,

        [Display(Name = "SEAD - Secretaria de Estado da Administração")]
        SEAD = 11,

        [Display(
            Name = "SEAGRI - Secretaria de Estado da Agricultura, Pecuária e Regularização Fundiária"
        )]
        SEAGRI = 10,

        [Display(Name = "SEARH - SUPERINTENDÊCIA ESTADUAL DE ADMINISTRAÇÃO E REC. HUMANOS")]
        SEARH = 70,

        [Display(Name = "SEAS - Secretaria de Estado da Assistência Social")]
        SEAS = 16,

        [Display(Name = "SEAS/2 - Assistência Social")]
        SEAS_2 = 1120,

        [Display(Name = "SECEL - Secretaria de Cultura, Esporte e Lazer")]
        SECEL = 22,

        [Display(Name = "SEDAM - Secretaria de Estado do Desenvolvimento Ambiental")]
        SEDAM = 9,

        [Display(Name = "SEDEC - Secretaria de Estado do Desenvolvimento Econômico")]
        SEDEC = 2639,

        [Display(Name = "SEDES - Secretaria de Estado do Desenvolvimento Econômico e Social")]
        SEDES = 7,

        [Display(Name = "SEDI - Secretaria de Estado de Desenvolvimento e Inovação")]
        SEDI = 112,

        [Display(Name = "SEDUC - Secretaria de Estado de Educação")]
        SEDUC = 3,

        [Display(Name = "SEFIN - Secretaria de Estado de Finanças")]
        SEFIN = 4,

        [Display(Name = "SEJUCEL - Superintendência da Juventude, Cultura, Esporte e Lazer")]
        SEJUCEL = 1116,

        [Display(Name = "SEJUS - Secretaria de Estado de Justiça")]
        SEJUS = 5,

        [Display(Name = "SEOSP - Secretaria de Estado de Obras e Serviços Públicos")]
        SEOSP = 1124,

        [Display(Name = "SEMAD - SECRETARIA MUNICIPAL DE ADMINISTRAÇÃO")]
        SEMAD = 76,

        [Display(Name = "SEMAGRIC - SECRETARIA MUNICIPAL DE AGRICULTURA E ABASTECIMENTO")]
        SEMAGRIC = 57,

        [Display(Name = "SEMAP - PREFEITURA MUNICIPAL DE URUPÁ")]
        SEMAP = 74,

        [Display(Name = "SEMAS - SECRETARIA MUNICIPAL DE ASSISTENCIA SOCIAL")]
        SEMAS = 79,

        [Display(
            Name = "SEMDESTUR - SECRETARIA MUNICIPAL DE DESENVOLVIMENTO SÓCIOECONÔMICO E TURISMO"
        )]
        SEMDESTUR = 64,

        [Display(Name = "SEMED - Secretaria Municipal de Educação")]
        SEMED = 59,

        [Display(Name = "SEMFAZ - Secretaria Municipal de Fazenda")]
        SEMFAZ = 61,

        [Display(Name = "SEMFAZ/JIPA - Secretaria Municipal de Fazenda")]
        SEMFAZ_JIPA = 87,

        [Display(Name = "SEMOB - SECREATARIA MUNICIPAL DE OBRAS")]
        SEMOB = 72,

        [Display(Name = "SEMPOG - SEMPOG")]
        SEMPOG = 77,

        [Display(Name = "SEMSAU - SECRETARIA MUNICIPAL DE DE SAÚDE ARIQUEMES")]
        SEMSAU = 56,

        [Display(Name = "SEMSAU/ARIQ - SECRETARIA MUNICIPAL DE SAÚDE DE ARIQUEMES")]
        SEMSAU_ARIQ = 75,

        [Display(Name = "SEMTRAN - SECRETARIA MUNICIPAL DE TRANSPORTES E TRÂNSITO")]
        SEMTRAN = 52,

        [Display(Name = "SEMUSA - ARACRUZ/ES")]
        SEMUSA = 68,

        [Display(Name = "SEMUSA - ARACRUZ/ES - SEMUSA - ARACRUZ / ES")]
        SEMUSA_ARACRUZ_ES = 69,

        [Display(Name = "SEMUSA/JIPA - Secretaria Municipal de Saúde de Ji Paraná")]
        SEMUSA_JIPA = 54,

        [Display(Name = "SEMUSB - Secretaria Municipal de Serviços e Obras Públicas")]
        SEMUSB = 60,

        [Display(
            Name = "SEPAT - Superintendência Estadual de Patrimônio e Regularização Fundiária"
        )]
        SEPAT = 1117,

        [Display(Name = "SEPAZ - Secretaria de Estado de Promoção da Paz")]
        SEPAZ = 46,

        [Display(Name = "SEPLAN - Secretaria de Estado do Planejamento e Coordenação Geral")]
        SEPLAN = 8,

        [Display(Name = "SEPOG - SECRETARIA DE ESTADO DO PLANEJAMENTO, ORÇAMENTO E GESTÃO")]
        SEPOG = 103,

        [Display(Name = "SESAP - SECRETARIA DE ESTADO DA SAÚDE PÚBLICA - RIO GRANDE DO NORTE")]
        SESAP = 111,

        [Display(Name = "SESAU - Secretaria de Estado de Saúde")]
        SESAU = 2,

        [Display(Name = "SESDEC - Secretaria de Estado da Segurança, Defesa e Cidadania")]
        SESDEC = 6,

        [Display(
            Name = "SETIC - Superintendência Estadual de Tecnologia da Informação e Comunicação"
        )]
        SETIC = 1573,

        [Display(Name = "SETUR - SECRETARIA ESTADUAL DE TURISMO")]
        SETUR = 28,

        [Display(Name = "SMSC - SECRETARIA MUNICIPAL DE SAÚDE DE CUIABÁ")]
        SMSC = 96,

        [Display(Name = "SOPH - Sociedade de Portos e Hidrovias")]
        SOPH = 25,

        [Display(Name = "SUGESP - Superintendência de Gestão de Gastos Públicos Administrativos")]
        SUGESP = 1122,

        [Display(Name = "SUGESPE - Superintendência de Gestão de Gastos Públicos Administrativos")]
        SUGESPE = 50,

        [Display(Name = "SEGEP - Superintendência Estadual de Gestão de Pessoas")]
        SEGEP = 269,

        [Display(Name = "SUPEL - SUPERITENDÊNCIA ESTADUAL DE LICITAÇÕES")]
        SUPEL = 32,

        [Display(Name = "TCE-RO - TRIBUNAL DE CONTAS DO ESTADO DE RODÔNIA")]
        TCE_RO = 42,

        [Display(Name = "TJ-RO - TRIBUNAL DE JUSTIÇA DO ESTADO DE RONDÔNIA")]
        TJ_RO = 43,

        [Display(Name = "TJ-TO - TRIBUNAL DE JUSTIÇA DE TOCANTINS")]
        TJ_TO = 65,
    }
}