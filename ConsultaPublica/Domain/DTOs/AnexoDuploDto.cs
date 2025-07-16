using Domain.Entities;

namespace Domain.DTOs
{
    public class AnexoDuploDto
    {
        public AnexoDuploDto()
        {
            AnexoAlterado = new Anexo();
            AnexoOriginal = new Anexo();
        }

        public Anexo AnexoOriginal { get; set; }
        public Anexo AnexoAlterado { get; set; }
    }
}