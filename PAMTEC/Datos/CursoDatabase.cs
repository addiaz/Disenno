using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    class CursoDatabase : AbtractDAL, ICursoDatabase
    {
        public DataTable ConsultarCurso() {
            SqlCommand comando = this.CrearComando();
            comando.CommandText = "select c.codigo as Codigo, c.Nombre as Nombre, c.Descripcion as Descripción from curso c";
            return this.EjecutarComandoSelect(comando);  
        
        
        }

        public int EliminarCurso(string codigo) {
            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@codigo", SqlDbType.VarChar, 50);
            comando.Parameters["@codigo"].Value = codigo;
            comando.CommandText = "Delete from curso where codigo = @codigo";
            return this.EjecutarComando(comando);

        }

        public int CrearCurso(string codigo, string nombre, string descripcion) {
            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@codigo", SqlDbType.VarChar, 50);
            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 50);

            comando.Parameters["@codigo"].Value = codigo;
            comando.Parameters["@nombre"].Value = nombre;
            comando.Parameters["@descripcion"].Value = descripcion;

            comando.CommandText = "insert into Curso values (@codigo, @nombre, @descripcion)";
            return this.EjecutarComando(comando);
        }

        public int EditarCurso(string codigo, string nombre, string descripcion)
        {
            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@codigo", SqlDbType.VarChar, 50);
            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 50);

            comando.Parameters["@codigo"].Value = codigo;
            comando.Parameters["@nombre"].Value = nombre;
            comando.Parameters["@descripcion"].Value = descripcion;

            comando.CommandText = "update curso set codigo = @codigo, nombre = @nombre, descripcion = @descripcion where codigo = @codigo";
            return this.EjecutarComando(comando);

        
        }
    }
}
