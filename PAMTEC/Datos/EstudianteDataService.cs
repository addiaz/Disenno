using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Pamtec.Datos
{
    public class EstudianteDataService : IEstudianteDataService
    {
        private readonly IEstudianteDatabase database;
        public EstudianteDataService()
        {
            this.database = new EstudianteDatabase();
        }

        public DataTable ObtenerEstudiantes()
        {
            return database.ObtenerEstudiantes();
        }
        public DataTable ObtenerEstudiantes_X_NombreApellido(string nombre, string apellido)
        {
            return this.database.ObtenerEstudiantes_X_NombreApellido(nombre, apellido);
        
        }
        public DataTable ObtenerEstudiantes_X_Nombre(string nombre) {
            return this.database.ObtenerEstudiantes_X_Nombre(nombre);
        
        }
        public DataTable ObtenerEstudiantes_X_Apellido(string apellido)
        {
            return this.database.ObtenerEstudiantes_X_Apellido(apellido);

        }

        public int IngresarEstudiante(string cedula, string nombre,  string apellidos, string fchNacimiento, string tel, string direccion)
        {
            return this.database.IngresarEstudiante(cedula, nombre, apellidos, fchNacimiento, tel, direccion);
        }

        public int EliminarEstudiante(string cedula)
        {
            return this.database.EliminarEstudiante(cedula);
        }

        public int EditarEstudiante(string nombre, string cedula, string apellidos, string fchNacimiento, string tel, string direccion)
        {
            return this.database.EditarEstudiante(nombre, cedula, apellidos, fchNacimiento, tel, direccion);
        }

        public DataTable reporteEstudiante(string cedula) {
            return this.database.reporteEstudiante(cedula);
        
        }

    }
}
