using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Negocio
{
    public interface ITutorService
    {
        //Ya aqui no deberia de retornar DataTables
        DataTable ObtenerTutores();
        DataTable ObtenerTutores_X_NombreApellido(string nombre, string apellido);
        DataTable ObtenerTutores_X_Nombre(string nombre);
        DataTable ObetenerTutores_X_Apellidos(string apellidos);       
        DataTable VerificarUsuario(string nombre, string pass);
        DataTable VerificarRol(string rol);
        int IngresarTutor(string carnet, string nombre, string apellidos, string fchNacimiento, string tel, string correo, string direccion, string categoria);
        int EliminarTutor(string carnet);
        int ActualizarTutor(string carnet, string nombre, string apellidos, string fchNacimiento, string tel, string correo, string direccion, string categoria);
        
        
    }
}