using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImprovedWorkCenter.Models
{
    public class Plan
    {
        public double Precio { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlanId { get; set; }

        [EnumDataType(typeof(TipoPlan))]
        public TipoPlan TipoPlan { get; set; }

        /*

        public Plan(double precio)
        {
            this.setPrecio(precio);
        }

        public void setPrecio(double precio)
        {
            if (precio > 0)
            {
                this.Precio = precio;
            } else
            {
                this.Precio = 0;
            }
        }

        public string print()
        {
            return "Precio: " + this.Precio + ".";

        }

        */
    }
}
