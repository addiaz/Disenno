using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio
{
    public interface IEstudianteService
    {
        DataTable ObtenerEstudiantes();
        DataTable ObtenerEstudiantes_X_NombreApellido(string nombre, string apellido);
        DataTable ObtenerEstudiantes_X_Nombre(string nombre);
        DataTable ObtenerEstudiantes_X_Apellido(string apellido);
        int IngresarEstudiante(string cedula, string nombre, string apellidos, string fchNacimiento, string tel, string direccion);
        int EditarEstudiante(string cedula, string nombre, string apellidos, string fchNacimiento, string tel, string direccion);
        int EliminarEstudiante(string cedula);
        DataTable reporteEstudiante(string cedula);
    }
}
