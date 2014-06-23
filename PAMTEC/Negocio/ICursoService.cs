using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public interface ICursoService
    {
        DataTable ConsultarCurso();
        int crearCurso(string codigo, string nombre, string descripcion);
        int EliminarCurso(string codigo);
        int EditarCurso(string codigo, string nombre, string descripcion);
      
      
    }
}
