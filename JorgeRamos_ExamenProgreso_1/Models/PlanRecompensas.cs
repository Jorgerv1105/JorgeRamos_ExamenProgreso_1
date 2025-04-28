using System.ComponentModel.DataAnnotations;

namespace JorgeRamos_ExamenProgreso_1.Models
{
    public class PlanRecompensas
    {
        [Key]
        public int PlanRecompensasId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Range(0, int.MaxValue)]
        public int PuntosAcumulados { get; set; }

        [Required]
        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados < 500 ? "SILVER" : "GOLD";
            }
        }

    }
}
