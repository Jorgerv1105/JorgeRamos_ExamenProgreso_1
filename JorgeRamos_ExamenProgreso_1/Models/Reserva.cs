using System.ComponentModel.DataAnnotations;

namespace JorgeRamos_ExamenProgreso_1.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }

        [Required]
        [Range(0, 10000)]
        public decimal ValorPagar { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
