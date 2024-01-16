using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV1
{
    public class Nomina
    {
        // MIEMBROS PRIVADOS DE LA CLASE
        private string _nombre;
        private string _apellidos;
        private string _puesto;
        private int _horasTrabajadas;
        private float _salarioHora;

        // PROPIEDADES
        /// <summary>
        /// Nombre del Empleado
        /// </summary>
        public string NombreEmpleado
        {
            get {
                // Control de Contenido
                if (string.IsNullOrEmpty(_nombre)) throw new Exception("Nombre del Trabajador no establecido");

                // Devolución del Valor
                return _nombre;
            }
            set {
                // Validación de los Datos a Establecer
                if (string.IsNullOrEmpty(value)) throw new Exception("El Nombre del Trabajador no puede ser null o la cadena vacía");

                // Establecimiento del valor al miembro privado
                _nombre = value;
            }
        }

    }
}
