using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    public class MatriculaDataService : IMatriculaDataService
    {
        private readonly IMatriculaDatabase database;
        public MatriculaDataService() {
            this.database = new MatriculaDatabase();
        
        }
        public DataTable Requisito(string cedula) {
            return database.Requisito(cedula);
        
        }

        public int Matricular(string cedula, int grupo) {
            return database.Matricular(cedula, grupo);
        
        }

        public int dismunuirCupo(string codigoAula, int cupo) {
            return database.dismunuirCupo(codigoAula, cupo);
        
        }
    }
}
