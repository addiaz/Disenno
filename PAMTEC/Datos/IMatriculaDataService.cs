using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamtec.Datos
{
    public interface IMatriculaDataService
    {
        DataTable Requisito(string cedula);
        int Matricular(string cedula, int grupo);
        int dismunuirCupo(string codigoAula, int cupo);
    }
}
