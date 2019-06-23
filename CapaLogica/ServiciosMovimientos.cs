using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaLogica
{    
    public class ServiciosMovimientos
    {
        RepositorioMovimientos repositorio = new RepositorioMovimientos();
        public List<Movimientos> VerMovimientos()
        {
            return repositorio.VerMovimientos();
        }
        public List<Movimientos> ConsultarTotal()
        {
            return repositorio.ConcultarTotal();
        }
        public List<Movimientos> VerPorFechas(DateTime fechaA, DateTime fechaB)
        {
            return repositorio.VerPorFechas(fechaA, fechaB);
        }
        public string RegistrarMovimiento(Movimientos movimientos)
        {
            return repositorio.RegistrarMovimiento(movimientos);
        }


    }
}
