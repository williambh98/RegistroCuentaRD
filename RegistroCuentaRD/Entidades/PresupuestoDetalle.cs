using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCuentaRD.Entidades
{
    public class PresupuestoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int PresuPuestoID { get; set; }
        public int CuentaID { get; set; }
        public float Valor { get; set; }

        public PresupuestoDetalle()
        {
            Id = 0;
            PresuPuestoID = 0;
            CuentaID = 0;
            Valor = 0;
        }

    }
}
