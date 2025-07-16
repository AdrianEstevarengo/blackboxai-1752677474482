using System.ComponentModel.DataAnnotations;

namespace Domain.Enums
{
    public enum MotivoPrioridadeEnum
    {
        [Display(Name = "Evento")] Evento,
        [Display(Name = "Pedido da unidade")] PedidoUnidade
    }
}