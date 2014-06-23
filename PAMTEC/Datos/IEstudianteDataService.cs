using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    public interface IEstudianteDataService
    {
        DataTable ObtenerEstudiantes();
        //int ConsultarEstudiante();
        DataTable ObtenerEstudiantes_X_NombreApellido(string nombre, string apellido);
        DataTable ObtenerEstudiantes_X_Nombre(string nombre);
        DataTable ObtenerEstudiantes_X_Apellido(string apellido);
        int EliminarEstudiante(string cedula);
        int EditarEstudiante(string cedula, string nombre, string apellidos, string fchNacimiento, string tel, string direccion);
        int IngresarEstudiante(string cedula, string nombre, string apellidos, string fchNacimiento, string tel, string direccion);
        DataTable reporteEstudiante(string cedula);
    }
}
