using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCuentaRD.Entidades
{
    public class Presupuesto
    {
        [Key]
        public int Presupuestoid { get; set; }
        public string Descripcion { get; set; }
        public float Monto { get; set; }
        public DateTime Fecha { get; set; }


        public virtual List<Cuentas> cuentas {get; set;}

        public Presupuesto()
        {
            Presupuestoid = 0;
            Descripcion = string.Empty;
            Monto = 0;
            Fecha = DateTime.Now;

            cuentas = new List<Cuentas>();
        }

    }
}
