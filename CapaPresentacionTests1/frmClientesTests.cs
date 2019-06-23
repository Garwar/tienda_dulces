using NUnit.Framework;
using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Tests
{
    [TestFixture()]
    public class frmClientesTests
    {
        
        [Test()]
        public void añadirClienteTest()
        {
            frmClientes frm = new frmClientes();
            string resultadoEsperado = frm.añadirCliente("1065843800", "Juan Antonio Reales Daza", "Calle 25 # 25-48", "3126854556", DateTime.Parse("01/01/2019"));
            Assert.That(resultadoEsperado, Is.EqualTo("Felicidades, Cliente agregado con exito."));
            //Assert.Fail();
        }

        [Test()]
        public void modificarClienteTest()
        {
            frmClientes frm = new frmClientes();
            string resultadoEsperado = frm.modificarCliente("1065843800", "Juan Antonio Reales Daza", "Calle 25 # 25-48", "3126854556");
            Assert.That(resultadoEsperado, Is.EqualTo("Felicidades, Cliente modificado con exito."));
            //Assert.Fail();
        }
    }
}