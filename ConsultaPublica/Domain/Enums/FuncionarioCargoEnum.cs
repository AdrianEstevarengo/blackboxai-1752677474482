using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum FuncionarioCargoEnum
    {
        [Display(Name = "Assesor(a)")]
        Assesor,
        [Display(Name = "Chefe e Assesoria Tecnica")]
        ChefeEAssesoriaTecncica,
        [Display(Name = "Chefe De Unidade")]
        ChefeUnicade,
        [Display(Name = "Chefe Gabinete")]
        ChefeGabinete,
        [Display(Name = "Coordenador(a)")]
        Coordenador,
        [Display(Name = "Controlador(a) Interno(a)")]
        ControladorInterno,
        [Display(Name = "Diretor(a) Executivo(a)")]
        DiretorExecutivo,
        [Display(Name = "Pregoeiro(a)")]
        Pregoeiro,
    }
}