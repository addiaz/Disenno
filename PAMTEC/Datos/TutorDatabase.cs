using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    public class TutorDatabase : AbtractDAL, ITutorDatabase
    {
        public DataTable ObtenerTutores()
        {
            SqlCommand comando = this.CrearComando();

            comando.CommandText = "Select t.carnet as Carne, t.nombre as Nombre, t.apellidos as Apellidos," +
             " t.fchNacimiento as FechaNacimiento, t.numeroTelefono as NumeroTelefono, t.correo as Correo, " +
             "t.direccion as Direccion, t.categoria as Categoria, t.usuario as Usuario from Tutor t";
            return EjecutarComandoSelect(comando);
        }

        public DataTable ObtenerTutores_X_NombreApellido(string nombre, string apellido) {

            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
            comando.Parameters.Add("@Apellidos", SqlDbType.VarChar, 50);
            comando.Parameters["@Nombre"].Value = nombre;
            comando.Parameters["@Apellidos"].Value = "%" + apellido + "%"; 
            comando.CommandText = "Select t.carnet as Carne, t.nombre as Nombre, t.apellidos as Apellidos," +
                " t.fchNacimiento as FechaNacimiento, t.numeroTelefono as NumeroTelefono, t.correo as Correo, " +
                "t.direccion as Direccion, t.categoria as Categoria, t.usuario as Usuario from Tutor t where t.nombre " +
                "like @Nombre and t.apellidos like @Apellidos";
            return this.EjecutarComandoSelect(comando);


        }

        public DataTable ObtenerTutores_X_Nombre(string nombre)
        {
            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
            comando.Parameters["@Nombre"].Value = "%" + nombre + "%"; ;      
            comando.CommandText = "Select t.carnet as Carne, t.nombre as Nombre, t.apellidos as Apellidos," +
                " t.fchNacimiento as FechaNacimiento, t.numeroTelefono as NumeroTelefono, t.correo as Correo, " +
                "t.direccion as Direccion, t.categoria as Categoria, t.usuario as Usuario from Tutor t where t.nombre like @Nombre";         
            return this.EjecutarComandoSelect(comando);
        }

        public DataTable ObetenerTutores_X_Apellidos(string apellidos) {
            SqlCommand comando = this.CrearComando();            
            comando.CommandText = "Select t.carnet as Carne, t.nombre as Nombre, t.apellidos as Apellidos," +
                " t.fchNacimiento as FechaNacimiento, t.numeroTelefono as NumeroTelefono, t.correo as Correo, " +
                "t.direccion as Direccion, t.categoria as Categoria, t.usuario as Usuario from Tutor t where t.apellidos like @Apellidos";
            comando.Parameters.Add("@Apellidos", SqlDbType.VarChar, 50);
            comando.Parameters["@Apellidos"].Value = "%" + apellidos + "%";
            return this.EjecutarComandoSelect(comando);
        
        }
        public DataTable VerificarUsuario(string nombre, string pass) {
            SqlCommand comando = this.CrearComando();         
            //comando.Parameters.AddWithValue("@nombre", nombre);
            //comando.Parameters.AddWithValue("@pass", pass);
            comando.CommandText = "Select usuario from Tutor t where t.usuario = '"+nombre+"' and t.pass = '"+pass+"' ";
            return this.EjecutarComandoSelect(comando);
        
        
        
        }

        public DataTable VerificarRol(string usuario) {
            SqlCommand comando = this.CrearComando();
            comando.CommandText = "select r.Nombre from Tutor t inner join Rol_Tutor rt  on t.carnet = rt.carnet  inner join Rol r on r.idRol = rt.idRol where t.Usuario = @usuarioT";
            comando.Parameters.AddWithValue("@usuarioT", usuario);
            return this.EjecutarComandoSelect(comando);
        }

        public int IngresarTutor(string carnet, string nombre, string apellidos, string fchNacimiento, string tel, string correo, string direccion, string categoria)
        {
            SqlCommand comando = this.CrearComando();
            DateTime fecha = Convert.ToDateTime(fchNacimiento);
            comando.CommandText = "Insert into Tutor values(@carnet, @nombre, @apellidos, @fchNacimiento, @tel, @correo, @direccion, @categoria, null, null)";
            comando.Parameters.AddWithValue("@carnet", carnet);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidos", apellidos);
           

            comando.Parameters.AddWithValue("@fchNacimiento", fecha);
            comando.Parameters.AddWithValue("@tel", tel);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@categoria", categoria);

            return this.EjecutarComando(comando);      
                
        }

        public int EliminarTutor(string carnet) {
            SqlCommand comando = this.CrearComandoProcedure();
            comando.Parameters.Add("@carnet", SqlDbType.VarChar, 50);
            comando.Parameters["@carnet"].Value = carnet;
            comando.CommandText = "sp_borrarTutor";
            return this.EjecutarComando(comando);
        
        }

        public int ActualizarTutor(string carnet, string nombre, string apellidos, string fchNacimiento, string tel, string correo, string direccion, string categoria)
        {
            SqlCommand comando = this.CrearComando();
            DateTime fecha = Convert.ToDateTime(fchNacimiento);
            comando.Parameters.Add("@carnet", SqlDbType.VarChar).Value = carnet;
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            comando.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = apellidos;
            comando.Parameters.Add("@fecha", SqlDbType.VarChar).Value = fecha;
            comando.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo;
            comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion;
            comando.Parameters.Add("@categoria", SqlDbType.VarChar).Value =categoria;

       

            comando.CommandText = "UPDATE tutor SET nombre =  @nombre, apellidos = @apellidos,  categoria= @categoria,correo=@correo,direccion= @direccion, fchNacimiento=@fecha, numeroTelefono= @tel WHERE carnet = @carnet";

            return this.EjecutarComando(comando);

                  

        


        
        }

    }
}
