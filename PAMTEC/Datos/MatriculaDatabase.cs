using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    public class MatriculaDatabase : AbtractDAL, IMatriculaDatabase
    {
        public DataTable Requisito(string cedula) {
            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;
            comando.CommandText = "select g.idGrupo, c.codigo,c.nombre as Nombre, c.descripcion as Descripción, g.idHorario, a.cupo as Cupo, g.codigoAula,g.fchInicio, g.fchFinal " +
                                  "from Curso c, grupo g inner join Aula a on g.codigoAula = a.codigoAula " +
                                  "where c.codigo in ( select  c.codigo as Código " +
                                                      "from Estudiante e inner join Estudiante_Curso ec " +
                                                      "on e.cedula=ec.cedula inner join Grupo tch on " +
                                                      "ec.idGrupo = tch.idGrupo inner join Requisito r on tch.codigo = r.Requisito inner join Curso c " +
                                                      "on r.codigo = c.codigo " +
                                                      "where ec.estado = 'aprobado' and e.cedula = @cedula) " +
                                                      "and c.codigo = g.codigo";
            return this.EjecutarComandoSelect(comando);
        }

        public int Matricular(string cedula, int grupo){
            SqlCommand comando =  this.CrearComando();
            comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;
            comando.Parameters.Add("@grupo", SqlDbType.Int).Value = grupo;
            //comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
            comando.CommandText = "insert into Estudiante_Curso values(@cedula, @grupo, 'En Curso')";
            return this.EjecutarComando(comando);

            
            }

      public int dismunuirCupo(string codigoAula, int cupo) {
            SqlCommand comando = this.CrearComando();
            comando.Parameters.Add("@codigoAula", SqlDbType.VarChar).Value = codigoAula;
            comando.Parameters.Add("@cupo", SqlDbType.Int).Value = cupo;
            comando.CommandText = "Update Aula set cupo = @cupo where codigoAula = @codigoAula";
            return this.EjecutarComando(comando);

        
        }



        }

       
    
}
