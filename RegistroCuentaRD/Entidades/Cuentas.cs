using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCuentaRD.Entidades
{
   public class Cuentas
    {
       [Key]
       public int CuentaID { get; set; }
       public string Descripcion { get; set; }
       //public int Tipoid { get; set; }
       public double Monto { get; set; }
  

        public Cuentas()
        {
            CuentaID = 0;
            Descripcion = string.Empty;
            //Tipoid = 0;
            Monto = 0;
        }
    }
}
