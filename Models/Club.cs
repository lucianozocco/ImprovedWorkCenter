using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImprovedWorkCenter.Models
{
    public class Club
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClubId { get; set; }

        [Required]
        [ForeignKey(nameof(Socio))]
        public int SocioId { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del club"), MaxLength(100)]
        public string Nombre { get; set; }
        public List<Socio> ListaSocios { get; set; }
        public List<Plan> ListaPlanes { get; set; }
        public List<Actividad> ListaActividades { get; set; }

        /*
        public Club(string nombre)
        {
            this.setNombre(nombre);
            this.ListaSocios = new List<Socio>();
            this.ListaDeudores = new List<Socio>();
            this.ListaPlanes = new List<Plan>();
            this.ListaActividades = new List<Actividad>();

        }

        public void VisualizarActividades()
        {
            foreach (var actividad in ListaActividades)
            {
                Console.WriteLine(actividad.print());
            }
        }

        public void VisualizarPlanes()
        {
            foreach (var plan in ListaPlanes)
            {
                Console.WriteLine(plan.print());
            }
        }

        public Boolean DarDeAltaSocio(Socio socio)
        {
            Boolean resultado = false;

            if (socio != null)
            {
                if (!this.BuscarSocio(socio.Nombre, ListaSocios))
                {
                    if (!this.BuscarSocio(socio.Nombre, ListaDeudores))
                    {
                        ListaSocios.Add(socio);
                    }
                }
            }

            return resultado;
        }

        public Boolean DarDeBaja(Socio socio)
        {
            Boolean resultado = false;

            if (socio != null)
            {
                if (this.BuscarSocio(socio.Nombre, ListaSocios))
                {
                    if (!this.BuscarSocio(socio.Nombre, ListaDeudores))
                    {
                        ListaSocios.Remove(socio);
                    }
                }
            }

            return resultado;
        }

        private Boolean BuscarSocio(string nombreSocio, List<Socio> lista)
        {
            Boolean resultado = false;
            Boolean encontrado = false;
            int i = 0;

            while (i < lista.Count && !encontrado)
            {
                if (lista[i].Nombre.Equals(nombreSocio))
                {
                    encontrado = true;
                    resultado = true;
                }
                else
                {
                    i++;
                }
            }
            return resultado;
        }

        public string getNombre()
        {
            return this.Nombre;
        }
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;

        }


        */


    }
}

