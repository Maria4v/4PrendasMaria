using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public class Modulo
    {
        // Este módulo sirve como se usa como si fuese el módulo de VB
        public static Negocio miNegocio = new Negocio();
        public static Empleado empleadoActual;
        public static List<Empleado> empleados = miNegocio.getEmpleados();
    }
}
