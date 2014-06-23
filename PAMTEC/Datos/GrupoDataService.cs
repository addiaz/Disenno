using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    public class GrupoDataService: IGrupoDataService
    {
          private readonly IGrupoDataBase database;

          public GrupoDataService()
        {
            this.database = new GrupoDataBase();
        }
        public DataTable consultar(string codigoGrupo, string carnet, string trimestre) {
            return this.database.consultar(codigoGrupo,carnet,trimestre);
        }

        public int insertarGrupo(int idGrupo, string codigo, string carnet, string fechaInicio, string fechaFinal, string aula, string trimestre) {
            return this.database.insertarGrupo(idGrupo, codigo, carnet, fechaInicio, fechaFinal, aula, trimestre);
        }
    
       
    }
}
