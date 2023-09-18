using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrosTickets.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }
        public DateTime FechaT { get; set; } = DateTime.Now;
        public int ClienteId { get; set; }
        public int SistemaId { get; set; }
        [Required(ErrorMessage = "Debes introducir una prioridad")]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "Debes indicar por quien es solicitado!!")]
        public string? SolicitadoPor { get; set; }
        [Required(ErrorMessage = "Debes indicar cual es el asunto!!")]
        public string? Asunto { get; set; }
        
        public string? Descripcion { get; set; }

    }
}
