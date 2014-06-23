using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pamtec.Datos;

namespace Negocio
{
    public class CursoService : ICursoService
    {
        private readonly ICursoDataService dataservice;
        public CursoService()
        {
            this.dataservice = new CursoDataService(); 
        }

        public DataTable ConsultarCurso()
        {
            return this.dataservice.ConsultarCurso();

        }

        public int crearCurso(string codigo, string nombre, string descripcion)
        {
            return this.dataservice.CrearCurso(codigo, nombre, descripcion);
        }

        public int EliminarCurso(string codigo)
        {
            return this.dataservice.EliminarCurso(codigo);
        }

        public int EditarCurso(string codigo, string nombre, string descripcion) {
            return this.dataservice.EditarCurso(codigo, nombre, descripcion);
        
        }

    }
}
