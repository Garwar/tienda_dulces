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
            string resultadoEsperado = frm.añadirCliente("1065843800", "Nilson Enrique Rosado Obredor", "calle 25 # 23-24", "3114332342", DateTime.Parse("01/01/2019"));
            Assert.That(resultadoEsperado, Is.EqualTo("Felicidades, Cliente agregado con exito."));
            
        }

        [Test()]
        public void modificarClienteTest()
        {
            frmClientes frm = new frmClientes();
            string resultadoEsperado = frm.modificarCliente("1065843800", "Nilson Enrique Rosado Obredor", "calle 25 # 23-24", "3114332342");
            Assert.That(resultadoEsperado, Is.EqualTo("Felicidades, Cliente modificado con exito."));
        }
    }
}