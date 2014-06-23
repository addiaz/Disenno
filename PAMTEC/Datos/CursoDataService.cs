using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
   public class CursoDataService: ICursoDataService
    {
        private readonly ICursoDatabase database;
        public CursoDataService() {
            this.database = new CursoDatabase();
        }
        public DataTable ConsultarCurso() {
            return this.database.ConsultarCurso();
        }

        public int EliminarCurso(string codigo)
        {
            return this.database.EliminarCurso(codigo);
        }

        public int CrearCurso(string codigo, string nombre, string descripcion) {

            return this.database.CrearCurso(codigo, nombre, descripcion);
        }

        public int EditarCurso(string codigo, string nombre, string descripcion) {
            return this.database.EditarCurso(codigo, nombre, descripcion);
        }
    }
}
