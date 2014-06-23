using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pamtec.Datos;
using System.Data;


namespace Negocio
{
    public class GrupoService: IGrupoService
    {
          private readonly IGrupoDataService dataservice;
          public GrupoService()
          {
           this.dataservice = new GrupoDataService();
       
       }
        public DataTable consultar(string codigoGrupo, string carnet, string trimestre)
        {
            return this.dataservice.consultar(codigoGrupo, carnet, trimestre);
        }

        public int insertarGrupo(int idGrupo, string codigo, string carnet, string fechaInicio, string fechaFinal, string aula, string trimestre)
        {
            return this.dataservice.insertarGrupo(idGrupo, codigo, carnet, fechaInicio, fechaFinal, aula, trimestre);
        }
    
    }
}
