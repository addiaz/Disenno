using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Negocio;
using Pamtec.Negocio;
using System.Data;

namespace PAMTEC.Aplicacion
{
    public partial class ConsultarCursoTutor : System.Web.UI.Page
    {
        private readonly ICursoService service;
        public ConsultarCursoTutor()
        {
            this.service = new CursoService(); ;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarInfo();
        }

        public void cargarInfo() {
            DataTable tabla = new DataTable();
            tabla = service.ConsultarCurso();
            if (tabla.Rows.Count > 0) {
                GridView1.DataSource = tabla;
                GridView1.DataBind();
                GridView1.Visible = true;
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}