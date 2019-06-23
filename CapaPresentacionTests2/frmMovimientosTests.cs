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
    public class frmMovimientosTests
    {      

        [Test()]
        public void registrarGastoTest()
        {
            frmMovimientos frm = new frmMovimientos();
            string resultadoEsperado = frm.registrarGasto(DateTime.Today, "5000", "pago recibo de luz");
            Assert.That(resultadoEsperado, Is.EqualTo("Movimiento registrado con exito"));
        }
    }
}