using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum ComplexidadeTecnica
    {
        [Display(Name = "Baixa (Especificações simples)")]
        Baixa = 1, // Especificações simples

        [Display(Name = "Média (Alguma especificidade técnica)")]
        Media = 2, // Alguma especificidade técnica

        [Display(Name = "Alta (Especificações complexas)")]
        Alta = 3, // Especificações complexas
    }
}
