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
    public class frmProductosTests
    {      

        [Test()]
        public void añadirExistenciasTest()
        {
            frmProductos frm = new frmProductos();
            string resultadoEsperado = frm.añadirExistencias("Dulce de leche", "Grande", "Duro", 5);
            Assert.That(resultadoEsperado, Is.EqualTo("Exito"));
        }
    }
}