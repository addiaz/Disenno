using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    class EstudianteDatabase :AbtractDAL , IEstudianteDatabase
    {
        public DataTable ObtenerEstudiantes()
        {
            SqlCommand comando = this.CrearComando();

            comando.CommandText = "select * from Estudiante";
            return EjecutarComandoSelect(comando);
        }

        public DataTable ObtenerEstudiantes_X_NombreApellido(string nombre, string apellido)
        {

            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
            comando.Parameters.Add("@Apellidos", SqlDbType.VarChar, 50);
            comando.Parameters["@Nombre"].Value = nombre;
            comando.Parameters["@Apellidos"].Value = "%" + apellido + "%";
            comando.CommandText = "select cedula as Cédula, nombre as Nombre, apellidos as Apellidos, fchNacimiento as FechaNacimiento," + 
                "numeroTelefono as NúmeroTelefono, direccion as Dirección from Estudiante where nombre like @Nombre and apellidos like @Apellidos";
            return this.EjecutarComandoSelect(comando);


        }

        public DataTable ObtenerEstudiantes_X_Nombre(string nombre)
        {
            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
            comando.Parameters["@Nombre"].Value = nombre;
            comando.CommandText = "select cedula as Cédula, nombre as Nombre, apellidos as Apellidos, fchNacimiento as FechaNacimiento," +
                "numeroTelefono as NúmeroTelefono, direccion as Dirección from Estudiante where nombre like @Nombre";
            return this.EjecutarComandoSelect(comando);
        }

        public DataTable ObtenerEstudiantes_X_Apellido(string apellido)
        {
            SqlCommand comando = this.CrearComando();
            comando.CommandText = "select cedula as Cédula, nombre as Nombre, apellidos as Apellidos, fchNacimiento as FechaNacimiento," +
                "numeroTelefono as NúmeroTelefono, direccion as Dirección from Estudiante where apellidos like @Apellidos";
            comando.Parameters.Add("@Apellidos", SqlDbType.VarChar, 50);
            comando.Parameters["@Apellidos"].Value = "%" + apellido + "%";
           // comando.Parameters["@Apellidos"].Value = apellido;
            return this.EjecutarComandoSelect(comando);

        }

        public DataTable obtenerEstudiante_X_carnet(string carnet) {

            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@carnet", SqlDbType.VarChar, 50);
            comando.Parameters["@carnet"].Value = carnet;
            comando.CommandText = "";
            return this.EjecutarComandoSelect(comando);
        
        }
        public int IngresarEstudiante(string cedula, string nombre,  string apellidos, string fchNacimiento, string tel, string direccion)
        {
            SqlCommand comando = this.CrearComando();
            DateTime fecha = Convert.ToDateTime(fchNacimiento);
            comando.CommandText = "insert into Estudiante values(@cedula, @nombre, @apellidos, @fchNacimiento, @tel, @direccion)";
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidos", apellidos);


            comando.Parameters.AddWithValue("@fchNacimiento", fecha);
            comando.Parameters.AddWithValue("@tel", tel);
            comando.Parameters.AddWithValue("@direccion", direccion);
     

            return this.EjecutarComando(comando);

        }
        public int EditarEstudiante(string cedula, string nombre, string apellidos, string fchNacimiento, string tel, string direccion)
        {
            SqlCommand comando = this.CrearComando();
            DateTime fecha = Convert.ToDateTime(fchNacimiento);
            comando.CommandText = "UPDATE Estudiante SET nombre =  @nombre, apellidos = @apellidos, direccion= @direccion, fchNacimiento=@fchNacimiento, numeroTelefono= @tel WHERE cedula = @cedula";
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidos", apellidos);
            comando.Parameters.AddWithValue("@fchNacimiento", fecha);
            comando.Parameters.AddWithValue("@tel", tel);
            comando.Parameters.AddWithValue("@direccion", direccion);


            return this.EjecutarComando(comando);

        }

        public int EliminarEstudiante(string cedula)
        {
            SqlCommand comando = this.CrearComandoProcedure();
            comando.Parameters.Add("@carnet", SqlDbType.VarChar, 50);
            comando.Parameters["@carnet"].Value = cedula;
            comando.CommandText = "";
            return this.EjecutarComando(comando);

        }

        public DataTable reporteEstudiante(string cedula) {

            SqlCommand comando = this.CrearComando();
            comando.CommandText = " select e.cedula, e.nombre + e.apellidos as nombre, g.numeroGrupo, c.nombre, t.nombre + t.apellidos as nombre,"+
            " g.fchInicio, g.fchFinal, g.codigoAula, g.trimestre, ec.estado from Estudiante_Curso ec inner join Grupo g on g.idGrupo = ec.idGrupo"+
             " inner join Tutor t   on t.carnet = g.carnet  inner join Curso c on c.codigo = g.codigo inner join Estudiante e "+ 
             " on e.cedula = ec.cedula  where ec.cedula = @cedula";
            comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;
            return this.EjecutarComandoSelect(comando);

        }

    }
}
