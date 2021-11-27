using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ImprovedWorkCenter.Models
{
    public class Socio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SocioId { get; set; }

        [Required]
        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Domicilio { get; set; }
        public string Mail { get; set; }
        public string Contrasenia { get; set; }

        public Boolean EsDeudor { get; set; }

        [Display(Name = "Fecha inscripción")]
        public string FechaInscripcion { get; set; }

        [EnumDataType(typeof(MetodoDePago))]
        public MetodoDePago MetodoDePago { get; set; }

        /*
        public Socio(string nombre, string apellido, int edad, string domicilio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Domicilio = domicilio;
        }



        */
    }
}