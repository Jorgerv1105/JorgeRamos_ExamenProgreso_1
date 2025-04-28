using System.ComponentModel.DataAnnotations;

namespace JorgeRamos_ExamenProgreso_1.Models
{
    public class Recompensa
    {
        [Key]
        public int RecompensaId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        public int PuntosAcumulados { get; set; }

        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados < 500 ? "SILVER" : "GOLD";
            }
        }

    }
}
