using AgendaConsulta.ViewModels;
using Domain.Entities;

namespace AgendaConsulta.Models
{
    public class HomeViewModel
    {
        public List<ProcessoAgendaViewModel> Processos { get; set; }
        public List<AtividadeViewModel> Atividades { get; set; }
    }
}
