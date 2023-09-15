using System.ComponentModel.DataAnnotations;

namespace RegistrosTickets.Model
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }

        public string? Descripcion { get; set; }

        public DateTime DiasCompromiso { get; set; } = DateTime.Now;
    }
}
