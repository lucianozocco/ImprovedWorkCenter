using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImprovedWorkCenter.Models
{
    public class ActividadSocio
    {
        // Clase/tabla intermedia para contener las FK

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Actividad))]
        public int ActividadId { get; set; }
        public Actividad Actividad { get; set; }

        [Required]
        [ForeignKey(nameof(Socio))]
        public int SocioId { get; set; }
        public Socio Socio { get; set; }

       
    }
}
