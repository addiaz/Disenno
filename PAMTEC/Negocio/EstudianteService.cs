using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pamtec.Datos;

using System.Data;

namespace Negocio
{
   public  class EstudianteService: IEstudianteService
    {
       private readonly IEstudianteDataService dataservice;
       public EstudianteService() {
           this.dataservice = new EstudianteDataService();
       
       }
       public DataTable ObtenerEstudiantes_X_NombreApellido(string nombre, string apellido)
       {
           return this.dataservice.ObtenerEstudiantes_X_NombreApellido(nombre, apellido);
       }

       public DataTable ObtenerEstudiantes_X_Nombre(string nombre) {
           return this.dataservice.ObtenerEstudiantes_X_Nombre(nombre);
       }

       public DataTable ObtenerEstudiantes_X_Apellido(string apellido)
       {
           return this.dataservice.ObtenerEstudiantes_X_Apellido(apellido);
       }
       public DataTable ObtenerEstudiantes()
       {
           return dataservice.ObtenerEstudiantes();
       }

       public int IngresarEstudiante(string cedula, string nombre, string apellidos, string fchNacimiento, string tel, string direccion)
       {
           return this.dataservice.IngresarEstudiante(cedula, nombre, apellidos, fchNacimiento, tel, direccion);
       }
       public int EditarEstudiante(string cedula, string nombre, string apellidos, string fchNacimiento, string tel, string direccion) {

           return this.dataservice.EditarEstudiante(cedula, nombre, apellidos, fchNacimiento, tel, direccion);
       }

       public int EliminarEstudiante(string cedula)
       {
           return this.dataservice.EliminarEstudiante(cedula);
       }

       public DataTable reporteEstudiante(string cedula)
       {
           return this.dataservice.reporteEstudiante(cedula);

       }



    }
}
