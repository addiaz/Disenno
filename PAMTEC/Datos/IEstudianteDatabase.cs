using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Pamtec.Datos
{
    public interface IEstudianteDatabase
    {
        DataTable ObtenerEstudiantes();
        //int ConsultarEstudiante();
        DataTable ObtenerEstudiantes_X_NombreApellido(string nombre, string apellido);
        DataTable ObtenerEstudiantes_X_Nombre(string nombre);
        DataTable ObtenerEstudiantes_X_Apellido(string apellidos);
        int EliminarEstudiante(string cedula);
        int EditarEstudiante(string cedula, string nombre, string apellidos, string fchNacimiento, string tel, string direccion);
        int IngresarEstudiante(string cedula, string nombre, string apellidos, string fchNacimiento, string tel, string direccion);
        DataTable reporteEstudiante(string cedula);
    }
}
