using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroCuentaRD.BLL;
using RegistroCuentaRD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCuentaRD.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TiposCuentas cuentas = new TiposCuentas();
            cuentas.TipoID = 1002;
            cuentas.Descripcion = "William";
            RepositorioBase<TiposCuentas> repositorio;
            repositorio = new RepositorioBase<TiposCuentas>();
            Assert.IsTrue(repositorio.Guardar(cuentas));
        }
    }
}