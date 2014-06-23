using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
   public interface IGrupoDataService
    {

        int insertarGrupo(int idGrupo, string codigo, string carnet, string fechaInicio, string fechaFinal, string aula, string trimestre);
        DataTable consultar(string codigoGrupo, string carnet, string trimestre);
    }
}
