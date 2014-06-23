using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pamtec.Datos;
using System.Data;

namespace Negocio
{
   
    public class MatriculaService: IMatriculaService
    {
        private readonly IMatriculaDataService dataservice;
        public MatriculaService() {

            this.dataservice = new MatriculaDataService();
        }

        public DataTable Requisito(string cedula) {
            return this.dataservice.Requisito(cedula);        
        }

        public int Matricular(string cedula, int grupo) {
            return this.dataservice.Matricular(cedula, grupo);
        
        }
        public int dismunuirCupo(string codigoAula, int cupo) {
            return this.dataservice.dismunuirCupo(codigoAula, cupo);
        
        }


    }
}
