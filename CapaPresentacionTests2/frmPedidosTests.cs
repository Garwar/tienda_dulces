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
    public class frmPedidosTests
    {
        [Test()]
        public void registrarPedidoTest()
        {
            frmPedidos frm = new frmPedidos();
            string resultadoEsperado = frm.registrarPedido("1065843800", 5000, "85000", "45000", "40000", DateTime.Parse("25/05/2019"));
            Assert.That(resultadoEsperado, Is.EqualTo("Pedido Generado correctamente."));
        }
    }
}