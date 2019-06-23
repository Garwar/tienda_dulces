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
    public class frmVentasTests
    {
        
        [Test()]
        public void agregarProductosTest()
        {
            frmVentas frm = new frmVentas();
            string resultadoEsperado = frm.agregarProductos("Dulce de leche", "Duro", "Grande", 1);
            Assert.That(resultadoEsperado, Is.EqualTo("Ok"));
        }
    }
}