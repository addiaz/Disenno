using Pamtec.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Negocio
{
    public class TutorService : ITutorService
    {
        private readonly ITutorDataService dataService;

        public TutorService()
        {
            this.dataService = new TutorDataService();
        }
        //Metodo para obtener todos la informacion de los tutores.
        public DataTable ObtenerTutores()
        {
            return this.dataService.ObtenerTutores();
        }

        //Metodo para obtener la informacion de los tutores tanto por nombre como por apellido.
        public DataTable ObtenerTutores_X_NombreApellido(string nombre, string apellido)
        {
            return this.dataService.ObtenerTutores_X_NombreApellido(nombre, apellido);
        }

        //Metodo para obtener informacion de los tutores por nombre.
        public DataTable ObtenerTutores_X_Nombre(string nombre)
        {
            return this.dataService.ObtenerTutores_X_Nombre(nombre);
        }

        //Metodo para obtener informacion de los tutores por apellido.
        public DataTable ObetenerTutores_X_Apellidos(string apellidos)
        {

            return this.dataService.ObetenerTutores_X_Apellidos(apellidos);
        }
        //Metodo para verificar si el usuario es correcto.
        public DataTable VerificarUsuario(string nombre, string pass)
        {

            return this.dataService.VerificarUsuario(nombre, pass);
        }

        //Metodo para verificar el rol cuando un usuario inisia sesion
        public DataTable VerificarRol(string rol)
        {


            return this.dataService.VerificarRol(rol);

        }

        //Metodo para ingresar un nuevo tutor
        public int IngresarTutor(string carnet, string nombre, string apellidos, string fchNacimiento, string tel, string correo, string direccion, string categoria)
        {

            return this.dataService.IngresarTutor(carnet, nombre, apellidos, fchNacimiento, tel, correo, direccion, categoria);
        }

        //Metodo para eliminar un tutor de acuerdo a un carnet
        public int EliminarTutor(string carnet) {
            return this.dataService.EliminarTutor(carnet);
        
        }
        //Metodo para actualizar tutores
        public int ActualizarTutor(string carnet, string nombre, string apellidos, string fchNacimiento, string tel, string correo, string direccion, string categoria)
        {
            return this.dataService.ActualizarTutor(carnet, nombre, apellidos, fchNacimiento, tel, correo, direccion, categoria);

        }
    }
}
