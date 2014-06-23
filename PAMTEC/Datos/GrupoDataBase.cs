using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
   public class GrupoDataBase : AbtractDAL, IGrupoDataBase
    {
       public int insertarGrupo(int idGrupo, string codigo, string carnet, string fechaInicio, string fechaFinal, string aula, string trimestre)
       {
           SqlCommand comando = this.CrearComando();
           comando.CommandText = "Insert into Grupo values(@idGrupo, @codigo, @carnet, NULL, @fechaIncio, @fechaFinal, @aula, @Trimestre)";
           comando.Parameters.AddWithValue("@idGrupo", SqlDbType.Int).Value = idGrupo;
           comando.Parameters.AddWithValue("@codigo", SqlDbType.VarChar).Value = codigo;
           comando.Parameters.AddWithValue("@carnet", SqlDbType.VarChar).Value = carnet;
           comando.Parameters.AddWithValue("@fechaIncio", SqlDbType.VarChar).Value = fechaInicio;
           comando.Parameters.AddWithValue("@fechaFinal", SqlDbType.VarChar).Value = fechaFinal;
           comando.Parameters.AddWithValue("@aula", SqlDbType.VarChar).Value = aula;
           comando.Parameters.AddWithValue("@trimestre", SqlDbType.VarChar).Value = trimestre;
           return this.EjecutarComando(comando);

       }

       public DataTable consultar(string codigoGrupo, string carnet, string trimestre ) {
           SqlCommand comando = this.CrearComando();
           comando.CommandText = "select * from Grupo where codigo =@codigo and carnet = @carnet and trimestre = @trimestre";
           comando.Parameters.AddWithValue("@codigo", SqlDbType.VarChar).Value = codigoGrupo;
           comando.Parameters.AddWithValue("@carnet", SqlDbType.VarChar).Value = carnet;
           comando.Parameters.AddWithValue("@trimestre", SqlDbType.VarChar).Value = trimestre;
           return this.EjecutarComandoSelect(comando);
        
       
       
       }


    }
}
