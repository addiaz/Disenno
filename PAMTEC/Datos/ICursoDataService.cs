using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    public interface ICursoDataService
    {
     
        DataTable ConsultarCurso();
        int EliminarCurso(string codigo);
        int CrearCurso(string codigo, string nombre, string descripcion);
        int EditarCurso(string codigo, string nombre, string descripcion);
    }
}
