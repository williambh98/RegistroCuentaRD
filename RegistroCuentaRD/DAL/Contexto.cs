using RegistroCuentaRD.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCuentaRD.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cuentas> Cuentas { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
     
        public DbSet<TiposCuentas> TCuentas { get; set; }

        public Contexto() : base("ConStr")
        {

        }

    }
}
