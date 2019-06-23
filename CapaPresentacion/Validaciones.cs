using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class Validaciones
    {
        public bool validarIdentificacion(string identificacion)
        {
            return identificacion.Length >= 6 && identificacion.Length <= 15; 
        }
        public bool validarTelefono(string telefono)
        {
            return telefono.Length >= 6 && telefono.Length <= 10;
        }
        public bool validarRazonGasto(string razonGasto)
        {
            return razonGasto.Length >= 5 && razonGasto.Length <= 250;
        }
    }
}
