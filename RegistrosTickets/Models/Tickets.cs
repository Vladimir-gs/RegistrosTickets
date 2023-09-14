using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrosTickets.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int SistemaId { get; set; }
        [Required(ErrorMessage = "Debes introducir una prioridad")]
        public int Prioridad { get; set; }
        [Required(ErrorMessage = "Debes indicar por quien es solicitado!!")]
        public string? SolicitadoPor { get; set; }
        [Required(ErrorMessage = "Debes indicar cual es el asunto!!")]
        public string? Asunto { get; set; }
        [ForeignKey("TicketId")]
        public string? Descripcion { get; set; }

    }

    public class TicketsDetalle
    {
        [Key]
        public int TicketsDetalleId { get; set; }
        public int TicketId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una Emisor")]
        public string Emisor { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una Mensaje")]
        public string Mensaje { get; set; }

    }
}
