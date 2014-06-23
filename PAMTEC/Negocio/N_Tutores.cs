using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Data.SqlClient;
using Pamtec.Datos;

namespace Pamtec.Negocio
{
    public class N_Tutores
    {
        //Constructor.. Esto no es un constructor

        private readonly ITutorService service;

        public N_Tutores()
        {
            this.service = new TutorService();
        }
        //D_Tutores tutores = new D_Tutores();

        public DataTable ObtenerTutores()
        {
            return this.service.ObtenerTutores();

        }

        public DataTable ObtenerTutores_X_Nombre(string nombre)
        {
            return this.service.ObtenerTutores_X_Nombre(nombre);

        }

    }
}
