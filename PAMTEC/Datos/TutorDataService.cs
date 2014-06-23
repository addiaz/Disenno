using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    public class TutorDataService : ITutorDataService
    {
        private readonly ITutorDatabase database;

        public TutorDataService()
        {
            this.database = new TutorDatabase();
        }
        public DataTable ObtenerTutores()
        {
            return this.database.ObtenerTutores();
        }
        public DataTable ObtenerTutores_X_NombreApellido(string nombre, string apellido)
        {
            return this.database.ObtenerTutores_X_NombreApellido(nombre, apellido);
        }

        public DataTable ObtenerTutores_X_Nombre(string nombre)
        {
            return this.database.ObtenerTutores_X_Nombre(nombre);
        }

        public DataTable ObetenerTutores_X_Apellidos(string apellido)
        {

            return this.database.ObetenerTutores_X_Apellidos(apellido);
        }

        public DataTable VerificarUsuario(string nombre, string pass)
        {
            return this.database.VerificarUsuario(nombre, pass);
        }

        public DataTable VerificarRol(string rol)
        {

            return this.database.VerificarRol(rol);
        }

        public int IngresarTutor(string carnet, string nombre, string apellidos, string fchNacimiento, string tel, string correo, string direccion, string categoria)
        {
            return this.database.IngresarTutor(carnet, nombre, apellidos, fchNacimiento, tel, correo, direccion, categoria);
        }

        public int EliminarTutor(string carnet) {
            return this.database.EliminarTutor(carnet);
        }


        public int ActualizarTutor(string carnet, string nombre, string apellidos, string fchNacimiento, string tel, string correo, string direccion, string categoria) {
            return this.database.ActualizarTutor(carnet, nombre, apellidos, fchNacimiento, tel, correo,direccion,categoria);
        
        }
        
    }
}
