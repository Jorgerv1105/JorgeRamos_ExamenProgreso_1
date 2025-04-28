using System.ComponentModel.DataAnnotations;

namespace JorgeRamos_ExamenProgreso_1.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Range(18, 100)]
        public int Edad { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public bool EsMiembro { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        public ICollection<Reserva> Reservas { get; set; }

    }
}
