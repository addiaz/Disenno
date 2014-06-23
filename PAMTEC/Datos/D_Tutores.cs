using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Datos
{
    public class D_Tutores
    {
        //Constructor
        public D_Tutores() { }
        //public string nombre { }

        // D_Tutores tutor = new D_Tutores();

        /*  public DataSet SeleccionarTodosTutores()
          {
              DataSet ds = new DataSet();
              var con = SingletonConecction.Instance.GetDBConnection();
              string consultaTutores = "Select * from Tutor";
              con.Open();
              SqlCommand comando = new SqlCommand(consultaTutores, con);
              SqlDataAdapter adaptador = new SqlDataAdapter(comando);
              adaptador.Fill(ds);
              con.Close();

              return ds;
          }*/

        public DataTable ObtenerTutores()
        {
            SqlCommand comando = CrearComando();
            comando.CommandText = "Select t.carnet as Carne, t.nombre as Nombre, t.apellidos as Apellidos," +
                " t.fchNacimiento as FechaNacimiento, t.numeroTelefono as NumeroTelefono, t.correo as Correo, " +
                "t.direccion as Direccion, t.categoria as Categoria, t.usuario as Usuario from Tutor";
            return EjecutarComandoSelect(comando);
        }

        public DataTable ObtenerTutores_X_Nombre(string nombre) {
            SqlCommand comando = CrearComando();
            comando.CommandText = "Select t.carnet as Carne, t.nombre as Nombre, t.apellidos as Apellidos," +
                " t.fchNacimiento as FechaNacimiento, t.numeroTelefono as NumeroTelefono, t.correo as Correo, " +
                "t.direccion as Direccion, t.categoria as Categoria, t.usuario as Usuario from Tutor t where t.nombre like @Nombre";
            comando.Parameters.AddWithValue("@Nombre", nombre);
            return EjecutarComandoSelect(comando);
        }
    }
}
